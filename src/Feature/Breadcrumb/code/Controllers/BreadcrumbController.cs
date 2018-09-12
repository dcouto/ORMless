using Feature.Breadcrumb.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.Breadcrumb.Controllers
{
    public class BreadcrumbController : Controller
    {
        private IBreadcrumbService _BreadcrumbService;

        public BreadcrumbController(IBreadcrumbService BreadcrumbService)
        {
            _BreadcrumbService = BreadcrumbService;
        }

        public ActionResult Default()
        {
            var model = _BreadcrumbService.GetBreadcrumb(RenderingContext.CurrentOrNull, Sitecore.Context.Item);

            return View(model);
        }
    }
}