using ORMless.Feature.GenericCarousel.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace ORMless.Feature.GenericCarousel.Controllers
{
    public class GenericCarouselController : Controller
    {
        private string _defaultViewPath = "/Views/Feature/GenericCarousel/Default.cshtml";
        private IGenericCarouselService _genericCarouselService;

        public GenericCarouselController(IGenericCarouselService genericCarouselService)
        {
            _genericCarouselService = genericCarouselService;
        }

        public ActionResult Default()
        {
            if(_genericCarouselService == null)
            {
                return View(_defaultViewPath);
            }

            var model = _genericCarouselService.GetGenericCarouselSlides(RenderingContext.CurrentOrNull);

            return View(_defaultViewPath, model);
        }
    }
}