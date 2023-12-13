using System.Web;
using System.Web.Mvc;

namespace OOP_Web_Project_Jover
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
