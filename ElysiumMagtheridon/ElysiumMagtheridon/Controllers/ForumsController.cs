using ElysiumMagtheridon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElysiumMagtheridon.Controllers
{
    public class ForumsController : Controller
    {
        //
        // GET: /Forums/
        public ActionResult Index()
        {
            var model = new PageModel();
            model.FooterText = "Forums";

            return View(model);
        }
	}
}