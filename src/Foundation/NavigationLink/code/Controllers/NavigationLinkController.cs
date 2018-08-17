using Foundation.NavigationLink.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Foundation.NavigationLink.Controllers
{
    public class NavigationLinkController : Controller
    {
        private INavigationLinkService _NavigationLinkService;

        public NavigationLinkController(INavigationLinkService NavigationLinkService)
        {
            _NavigationLinkService = NavigationLinkService;
        }

        public ActionResult Default()
        {
            var model = _NavigationLinkService.GetNavigationLink(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}