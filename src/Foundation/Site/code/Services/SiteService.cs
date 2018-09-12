using Foundation.BaseClasses.Services;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Foundation.Site.Services
{
    public class SiteService : BaseService, ISiteService
    {
        public Models.Site GetSite(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.Site(GetDatasource(renderingContext, contextItem, _Site_Constants.TemplateId));

            return model;
        }
    }
}