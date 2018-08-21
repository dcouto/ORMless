/// <binding />
// Alphabetical Order
var debug = require("gulp-debug");
var foreach = require("gulp-foreach");
var fs = require('fs');
var gulp = require("gulp");
var msbuild = require("gulp-msbuild");
var nugetRestore = require('gulp-nuget-restore');
var runSequence = require("run-sequence");

var config;

if (fs.existsSync('./gulp-config.js.user')) {
    config = require("./gulp-config.js.user")();
}
else {
    config = require("./gulp-config.js")()
}

module.exports.config = config;

gulp.task("default", function (callback) {
    config.runCleanBuilds = true;

    return runSequence(
        "01-Nuget-Restore",
        publishProjects(),
        callback);
});

/*****************************
  Initial setup
*****************************/
gulp.task("01-Nuget-Restore", function (callback) {
    var solution = "./" + config.solutionName + ".sln";
    return gulp.src(solution).pipe(nugetRestore());
});

gulp.task("02-Publish-All-Projects", function (callback) {
    return runSequence(
        "Build-Solution",
        "Publish-Foundation-Projects",
        "Publish-Feature-Projects",
        "Publish-Project-Projects",
        callback);
});


/*****************************
  Publish
*****************************/
var publishStream = function (stream, dest) {
    var targets = ["Build"];

    return stream
        .pipe(debug({ title: "Building project:" }))
        .pipe(msbuild({
            targets: targets,
            configuration: config.buildConfiguration,
            logCommand: false,
            verbosity: config.buildVerbosity,
            stdout: true,
            errorOnFail: true,
            maxcpucount: config.buildMaxCpuCount,
            nodeReuse: false,
            toolsVersion: config.buildToolsVersion,
            properties: {
                Platform: config.publishPlatform,
                DeployOnBuild: "true",
                DeployDefaultTarget: "WebPublish",
                WebPublishMethod: "FileSystem",
                DeleteExistingFiles: "false",
                publishUrl: dest,
                _FindDependencies: "false"
            }
        }));
}

var publishProject = function (dest) {
    dest = dest || config.websiteRoot;

    return gulp.src(["./src/**/*.csproj"])
        .pipe(foreach(function (stream, file) {
            return publishStream(stream, dest);
        }));
}

var publishProjects = function () {
    return gulp
        .src(["./src/**/*.csproj"])
        .pipe(foreach(function (stream, file) {
            return publishStream(stream, config.websiteRoot);
        }));
};

gulp.task("Build-Solution", function () {
    var targets = ["Build"];

    if (config.runCleanBuilds) {
        targets = ["Clean", "Build"];
    }

    var solution = "./" + config.solutionName + ".sln";

    return gulp.src(solution)
        .pipe(msbuild({
            targets: targets,
            configuration: config.buildConfiguration,
            logCommand: false,
            verbosity: config.buildVerbosity,
            stdout: true,
            errorOnFail: true,
            maxcpucount: config.buildMaxCpuCount,
            nodeReuse: false,
            toolsVersion: config.buildToolsVersion,
            properties: {
                Platform: config.buildPlatform
            }
        }));
});

gulp.task("Publish-Foundation-Projects", function () {
    return publishProjects(config.foundationPaths);
});

gulp.task("Publish-Feature-Projects", function () {
    return publishProjects(config.featurePaths);
});

gulp.task("Publish-Project-Projects", function () {
    return publishProjects(config.projectPaths);
});