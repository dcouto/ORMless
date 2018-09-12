using Foundation.Publications.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Foundation.Publications.Controllers
{
    public class PublicationsController : Controller
    {
        private IPublicationsService _PublicationsService;

        public PublicationsController(IPublicationsService PublicationsService)
        {
            _PublicationsService = PublicationsService;
        }

        public ActionResult Default()
        {
            var model = _PublicationsService.GetPublications(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}