using Feature.GenericJumbotron.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace Feature.GenericJumbotron.Controllers
{
    public class GenericJumbotronController : Controller
    {
        private IGenericJumbotronService _GenericJumbotronService;

        public GenericJumbotronController(IGenericJumbotronService GenericJumbotronService)
        {
            _GenericJumbotronService = GenericJumbotronService;
        }

        public ActionResult Default()
        {
            var model = _GenericJumbotronService.GetGenericJumbotron(RenderingContext.CurrentOrNull, Sitecore.Context.Item);

            return View(model);
        }
    }
}