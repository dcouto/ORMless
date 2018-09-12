using Feature.Events.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.Events.Controllers
{
    public class EventsListingController : Controller
    {
        private IEventsService _EventsService;

        public EventsListingController(IEventsService EventsService)
        {
            _EventsService = EventsService;
        }

        public ActionResult Default()
        {
            var model = _EventsService.GetEventsLsting(RenderingContext.CurrentOrNull, Sitecore.Context.Item);

            return View(model);
        }
    }
}