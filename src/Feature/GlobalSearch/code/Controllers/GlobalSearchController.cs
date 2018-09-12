using Feature.GlobalSearch.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.GlobalSearch.Controllers
{
    public class GlobalSearchController : Controller
    {
        private IGlobalSearchService _GlobalSearchService;

        public GlobalSearchController(IGlobalSearchService GlobalSearchService)
        {
            _GlobalSearchService = GlobalSearchService;
        }

        public ActionResult Default(string q)
        {
            var model = _GlobalSearchService.GetGlobalSearch(RenderingContext.CurrentOrNull, Sitecore.Context.Item, q);

            return View(model);
        }
    }
}