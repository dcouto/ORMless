module.exports = function () {
    var instanceRoot = "C:\\inetpub\\wwwroot\\tyco.local";
    var config = {
        websiteRoot: instanceRoot,
        sitecoreLibraries: instanceRoot + "\\bin",
        licensePath: instanceRoot + "\\App_Data\\license.xml",
        solutionName: "Tyco",
        buildConfiguration: "Debug",
        buildToolsVersion: 15.0,
        buildMaxCpuCount: 0,
        buildVerbosity: "minimal",
        buildPlatform: "Any CPU",
        publishPlatform: "AnyCpu",
        runCleanBuilds: false,
        foundationPaths: [
            "../../Foundation/404/code/Universal.Foundation.404.csproj",

            "../../Foundation/BaseContent/code/Universal.Foundation.BaseContent.csproj",

            "../../Foundation/Common/code/Universal.Foundation.Common.csproj",

            "../../Foundation/CustomAliasResolver/code/Universal.Foundation.CustomAliasResolver.csproj",

            "../../Foundation/Extensions/code/Universal.Foundation.Extensions.csproj",

            "../../Foundation/Multisite/code/Universal.Foundation.Multisite.csproj",

            "../../Foundation/ORM/code/Universal.Foundation.ORM.csproj",             
             
            "../../Foundation/PageMetadata/code/Universal.Foundation.PageMetadata.csproj",

            "../../Foundation/Theming/code/Universal.Foundation.Theming.csproj"
        ],
        featurePaths: [
            "../../Feature/GenericCallout/code/Universal.Feature.GenericCallout.csproj",
            "../../Feature/Components/code/Universal.Feature.Components.csproj",
            "../../Feature/Insights/code/Universal.Feature.Insights.csproj",
            "../../Feature/Navigation/code/Universal.Feature.Navigation.csproj"
        ],
        projectPaths: [
            "./code/Tyco.Project.Site.csproj"
        ]
    };

    return config;
}
