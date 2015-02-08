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
        private IProgressionItem[] Videos;

        public ProgressionController(IProgressionItem[] vids)
        {
            this.Videos = vids;
        }

        //
        // GET: /Progression/
        public ActionResult Index(IProgressionItem[] vids)
        {
            this.Videos = vids;
            return View();
        }
	}
}