using Foundation.BaseClasses.Services;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.GenericJumbotron.Services
{
    public class GenericJumbotronService : BaseService, IGenericJumbotronService
    {
        public Models.GenericJumbotron GetGenericJumbotron(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.GenericJumbotron(GetDatasource(renderingContext, contextItem, Generic_Jumbotron_Constants.TemplateId));

            return model;
        }
    }
}