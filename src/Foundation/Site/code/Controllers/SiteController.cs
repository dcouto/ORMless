using Foundation.Site.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Foundation.Site.Controllers
{
    public class SiteController : Controller
    {
        private ISiteService _SiteService;

        public SiteController(ISiteService SiteService)
        {
            _SiteService = SiteService;
        }

        public ActionResult Default()
        {
            var model = _SiteService.GetSite(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}