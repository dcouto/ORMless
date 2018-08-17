using Foundation.SharedContent.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Foundation.SharedContent.Controllers
{
    public class SharedContentController : Controller
    {
        private ISharedContentService _SharedContentService;

        public SharedContentController(ISharedContentService SharedContentService)
        {
            _SharedContentService = SharedContentService;
        }

        public ActionResult Default()
        {
            var model = _SharedContentService.GetSharedContent(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}