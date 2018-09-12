using Sitecore.Mvc.Presentation;

namespace Foundation.DatedContent.Services
{
    public interface IDatedContentService
    {
        Models.DatedContent GetDatedContent(RenderingContext renderingContext);
    }
}
