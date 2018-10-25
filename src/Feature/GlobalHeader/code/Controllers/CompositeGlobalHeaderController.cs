using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feature.GlobalHeader.Controllers
{
    public class CompositeGlobalHeaderController : Controller
    {
        public ActionResult Default()
        {
            return View();
        }
    }
}