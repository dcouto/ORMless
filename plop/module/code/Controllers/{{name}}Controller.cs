﻿using {{layer}}.{{name}}.Services;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace {{layer}}.{{name}}.Controllers
{
    public class {{name}}Controller : Controller
    {
        private I{{name}}Service _{{name}}Service;

        public {{name}}Controller(I{{name}}Service {{name}}Service)
        {
            _{{name}}Service = {{name}}Service;
        }

        public ActionResult Default()
        {
            var model = _{{name}}Service.Get{{name}}(RenderingContext.CurrentOrNull);

            return View(model);
        }
    }
}