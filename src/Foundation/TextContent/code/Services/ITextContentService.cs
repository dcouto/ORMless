using Sitecore.Mvc.Presentation;

namespace Foundation.TextContent.Services
{
    public interface ITextContentService
    {
        Models.TextContent GetTextContent(RenderingContext renderingContext);
    }
}
