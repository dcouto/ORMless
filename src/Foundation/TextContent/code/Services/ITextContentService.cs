using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Foundation.TextContent.Services
{
    public interface ITextContentService
    {
        Models.TextContent GetTextContent(RenderingContext renderingContext, Item contextItem);
    }
}
