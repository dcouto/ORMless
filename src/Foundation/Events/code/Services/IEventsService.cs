using Sitecore.Mvc.Presentation;

namespace Foundation.Events.Services
{
    public interface IEventsService
    {
        Models.Events GetEvents(RenderingContext renderingContext);
    }
}
