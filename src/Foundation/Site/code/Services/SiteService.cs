using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Foundation.Site.Services
{
    public class SiteService : BaseService, ISiteService
    {
        public Models.Site GetSite(RenderingContext renderingContext)
        {
            var model = new Models.Site(GetDatasource(renderingContext, _Site_Constants.TemplateId));

            return model;
        }
    }
}