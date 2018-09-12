using Foundation.DatedContent.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Foundation.DatedContent.Controllers
{
    public class DatedContentController : Controller
    {
        private IDatedContentService _DatedContentService;

        public DatedContentController(IDatedContentService DatedContentService)
        {
            _DatedContentService = DatedContentService;
        }

        public ActionResult Default()
        {
            var model = _DatedContentService.GetDatedContent(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}