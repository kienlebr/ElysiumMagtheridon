using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElysiumMagtheridon.Models;

namespace ElysiumMagtheridon.Controllers
{
    public class ProgressionController : Controller
    {
        //
        // GET: /Progression/
        public ActionResult Index()
        {
            var model = new PageModel();
            model.FooterText = "Progression";

            return View(model);
        }
	}
}