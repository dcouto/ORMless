var Guid = require('guid');
var { readdirSync } = require('fs');
var { join } = require('path');

module.exports = function (plop) {
    var titleCase = (txt) => txt.charAt(0).toUpperCase() + txt.slice(1);
    var pascalCase = (txt) => txt.split(' ').map(titleCase).join('');
    var newGuid = () => '{' + Guid.create().value + '}';

    plop.setGenerator('module', {
		description: 'creates a new module project and TDS project',
		prompts: [{
            type: 'list',
            choices: ['Foundation', 'Feature', 'Project'],
			name: 'layer',
            message: 'Which layer?'
        },
        {
			type: 'input',
			name: 'name',
            message: 'What\'s the name of your module?',
            filter: pascalCase,
            transformer: pascalCase
        },
        {
            type: 'input',
            name: 'name_underscore',
            message: 'Enter the module name again with underscores:',
            filter: pascalCase,
            transformer: pascalCase
        }],
		actions: [{
            type: 'addMany',
            data: {
                webProjectGuid: newGuid(),
                tdsProjectGuid: newGuid()
            },
            destination: 'src/{{layer}}/{{name}}/',
            base: 'plop/module',
			templateFiles: '**/*.*'
		}]
    });

    plop.setGenerator('rendering',
        {
            description: 'creates a new rendering in your feature',
            prompts: [
                {
                    name: 'layer',
                    type: 'list',
                    choices: ['Foundation', 'Feature', 'Project'],
                    message: 'Which layer?'
                },
                {
                    name: 'module',
                    type: 'list',
                    choices: function(data) {
                        var featuresDir = join(__dirname, '../../' + data.layer);
                        return readdirSync(featuresDir);
                    },
                    message: 'Which module?',
                },
                {
                    name: 'name',
                    type: 'input',
                    message: 'What\'s the name of your rendering?',
                    filter: pascalCase,
                    transformer: pascalCase
                }
            ],
            actions: [
                {
                    type: 'addMany',
                    destination: 'src/{{layer}}/{{module}}/code/Views/{{module}}/',
                    base: 'plop/rendering',
                    templateFiles: '**/*.*'
                }]
        });
}