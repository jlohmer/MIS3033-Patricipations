﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _P__Bootstrap_HTML_CSS.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Employees()
        {
            ViewBag.Message = "This is the employee page";
            return View();
        }
    }
}