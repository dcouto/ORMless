using Sitecore.Mvc.Presentation;

namespace ORMless.Feature.GenericCallout.Services
{
    public interface IGenericCalloutService
    {
        Models.GenericCallout GetGenericCallout(RenderingContext renderingContext);
    }
}
