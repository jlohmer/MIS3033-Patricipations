using System.Web;
using System.Web.Mvc;

namespace _P__Bootstrap_HTML_CSS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
