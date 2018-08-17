using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Foundation.NavigationLink.Services
{
    public class NavigationLinkService : BaseService, INavigationLinkService
    {
        public Models.NavigationLink GetNavigationLink(RenderingContext renderingContext)
        {
            var model = new Models.NavigationLink(GetDatasource(renderingContext, _Navigation_Link_Constants.TemplateId));

            return model;
        }
    }
}