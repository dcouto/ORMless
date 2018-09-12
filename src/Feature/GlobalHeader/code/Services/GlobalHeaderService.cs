using Foundation.BaseClasses.Services;
using Foundation.Extensions;
using Foundation.NavigationLink;
using Foundation.Site.Factories;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Linq;

namespace Feature.GlobalHeader.Services
{
    public class GlobalHeaderService : BaseService, IGlobalHeaderService
    {
        public Models.GlobalHeader GetGlobalHeader(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.GlobalHeader(GetDatasource(renderingContext, contextItem, Global_Header_Constants.TemplateId));

            // the GetDatasource returned no Sitecore item or it returned an item of the wrong template
            if(model.SitecoreItem == null || !model.SitecoreItem.IsOrInherits(Global_Header_Constants.TemplateId))
            {
                var site = SiteFactory.GetSite();

                if(site != null)
                {
                    model.SitecoreItem = site.GetDefaultGlobalHeader();
                }
            }

            if(model.SitecoreItem != null)
            {
                model.NavigationLinks = model.SitecoreItem.Children.Where(i => i.IsOrInherits(_Navigation_Link_Constants.TemplateId));
            }

            return model;
        }
    }
}