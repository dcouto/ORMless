using Foundation.Events.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Foundation.Events.Controllers
{
    public class EventsController : Controller
    {
        private IEventsService _EventsService;

        public EventsController(IEventsService EventsService)
        {
            _EventsService = EventsService;
        }

        public ActionResult Default()
        {
            var model = _EventsService.GetEvents(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}