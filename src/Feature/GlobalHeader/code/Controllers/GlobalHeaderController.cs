using Feature.GlobalHeader.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.GlobalHeader.Controllers
{
    public class GlobalHeaderController : Controller
    {
        private IGlobalHeaderService _GlobalHeaderService;

        public GlobalHeaderController(IGlobalHeaderService GlobalHeaderService)
        {
            _GlobalHeaderService = GlobalHeaderService;
        }

        public ActionResult Default()
        {
            var model = _GlobalHeaderService.GetGlobalHeader(RenderingContext.CurrentOrNull, Sitecore.Context.Item);

            return View(model);
        }
    }
}