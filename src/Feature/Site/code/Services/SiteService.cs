using Foundation.BaseClasses.Services;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.Site.Services
{
    public class SiteService : BaseService, ISiteService
    {
        public Models.Site GetSite(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.Site(GetDatasource(renderingContext, contextItem, Site_Constants.TemplateId));

            return model;
        }
    }
}