using _P_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _P_MVC.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            Students stud1 = new Students();
            stud1.StudentID = 1;
            stud1.FirstName = "Jason";
            stud1.LastName = "Lohmer";
            stud1.FavoriteColor = "Red";


            return View(stud1);
        }
    }
}