using Feature.Site.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.Site.Controllers
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
            var model = _SiteService.GetSite(RenderingContext.CurrentOrNull, Sitecore.Context.Item);

            return View(model);
        }
    }
}