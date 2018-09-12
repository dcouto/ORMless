using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Foundation.NavigationLink.Services
{
    public interface INavigationLinkService
    {
        Models.NavigationLink GetNavigationLink(RenderingContext renderingContext, Item contextItem);
    }
}
