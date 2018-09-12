using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.Events.Services
{
    public interface IEventsService
    {
        Models.EventsListing GetEventsLsting(RenderingContext renderingContext, Item contextItem);
    }
}
