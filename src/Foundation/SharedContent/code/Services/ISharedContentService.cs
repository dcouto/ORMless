using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Foundation.SharedContent.Services
{
    public interface ISharedContentService
    {
        Models.SharedContent GetSharedContent(RenderingContext renderingContext, Item contextItem);
    }
}
