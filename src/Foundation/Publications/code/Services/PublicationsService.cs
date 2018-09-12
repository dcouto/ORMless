using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Foundation.Publications.Services
{
    public class PublicationsService : BaseService, IPublicationsService
    {
        public Models.Publications GetPublications(RenderingContext renderingContext)
        {
            return null;

            //var model = new Models.Publications(GetDatasource(renderingContext, Publications_Constants.TemplateId));

            //return model;
        }
    }
}