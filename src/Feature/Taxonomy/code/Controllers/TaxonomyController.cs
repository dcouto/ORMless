using Feature.Taxonomy.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.Taxonomy.Controllers
{
    public class TaxonomyController : Controller
    {
        private ITaxonomyService _TaxonomyService;

        public TaxonomyController(ITaxonomyService TaxonomyService)
        {
            _TaxonomyService = TaxonomyService;
        }

        public ActionResult Default()
        {
            var model = _TaxonomyService.GetTaxonomy(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}