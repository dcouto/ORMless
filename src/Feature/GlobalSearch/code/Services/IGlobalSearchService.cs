using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.GlobalSearch.Services
{
    public interface IGlobalSearchService
    {
        Models.GlobalSearch GetGlobalSearch(RenderingContext renderingContext, Item contextItem, string q);
    }
}
