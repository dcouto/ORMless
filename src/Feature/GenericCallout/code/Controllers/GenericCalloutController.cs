﻿using ORMless.Feature.GenericCallout.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace ORMless.Feature.GenericCallout.Controllers
{
    public class GenericCalloutController : Controller
    {
        private string _defaultViewPath = "/Views/Feature/GenericCallout/Default.cshtml";
        private IGenericCalloutService _genericCalloutService;

        public GenericCalloutController(IGenericCalloutService genericCalloutService)
        {
            _genericCalloutService = genericCalloutService;
        }

        public ActionResult Default()
        {
            var model = _genericCalloutService.GetGenericCallout(RenderingContext.CurrentOrNull);

            return View(_defaultViewPath, model);
        }
    }
}