using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _P__Bootstrap_HTML_CSS.Models;

namespace _P__Bootstrap_HTML_CSS.Controllers
{
    public class DeveloperInfoController : Controller
    {
        // GET: DeveloperInfo
        public ActionResult Index()
        {
            DeveloperInformation info = new DeveloperInformation();
            info.Name = "Jason Lohmer";
            return View(info);
        }
    }
}