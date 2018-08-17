using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace {{layer}}.{{name}}.Services
{
    public class {{name}}Service : BaseService, I{{name}}Service
    {
        public Models.{{name}} Get{{name}}(RenderingContext renderingContext)
        {
            var model = new Models.{{name}}(GetDatasource(renderingContext, {{name_underscore}}_Constants.TemplateId));

            return model;
        }
    }
}