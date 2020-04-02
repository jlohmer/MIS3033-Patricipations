using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _P_MVC.Models
{
    public class Students
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }

        public Students()
        {
            StudentID = 0;
            FirstName = "";
            LastName = "";
            FavoriteColor = "";
        }
    }
}