using Foundation.BaseClasses.Services;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Foundation.NavigationLink.Services
{
    public class NavigationLinkService : BaseService, INavigationLinkService
    {
        public Models.NavigationLink GetNavigationLink(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.NavigationLink(GetDatasource(renderingContext, contextItem, _Navigation_Link_Constants.TemplateId));

            return model;
        }
    }
}