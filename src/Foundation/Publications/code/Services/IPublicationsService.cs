using Sitecore.Mvc.Presentation;

namespace Foundation.Publications.Services
{
    public interface IPublicationsService
    {
        Models.Publications GetPublications(RenderingContext renderingContext);
    }
}
