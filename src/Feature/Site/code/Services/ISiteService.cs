using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.Site.Services
{
    public interface ISiteService
    {
        Models.Site GetSite(RenderingContext renderingContext, Item contextItem);
    }
}
