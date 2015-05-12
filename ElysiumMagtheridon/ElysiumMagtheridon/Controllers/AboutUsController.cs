using ElysiumMagtheridon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElysiumMagtheridon.Controllers
{
    public class AboutUsController : Controller
    {
        //
        // GET: /AboutUs/
        public ActionResult Index()
        {
            var model = new PageModel();
            model.FooterText = "About Us";

            return View(model);
        }
	}
}