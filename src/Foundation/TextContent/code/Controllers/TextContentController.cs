using Foundation.TextContent.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Foundation.TextContent.Controllers
{
    public class TextContentController : Controller
    {
        private ITextContentService _TextContentService;

        public TextContentController(ITextContentService TextContentService)
        {
            _TextContentService = TextContentService;
        }

        public ActionResult Default()
        {
            var model = _TextContentService.GetTextContent(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}