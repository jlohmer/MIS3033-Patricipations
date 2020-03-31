using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _P__Bootstrap_HTML_CSS.Models
{
    public class DeveloperInformation
    {
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public DeveloperInformation()
        {
            Name = "";
            CreationDate = DateTime.Now;
        }
    }
}