using Feature.GenericCard.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.GenericCard.Controllers
{
    public class GenericCardController : Controller
    {
        private IGenericCardService _GenericCardService;

        public GenericCardController(IGenericCardService GenericCardService)
        {
            _GenericCardService = GenericCardService;
        }

        public ActionResult Default()
        {
            var model = _GenericCardService.GetGenericCard(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}