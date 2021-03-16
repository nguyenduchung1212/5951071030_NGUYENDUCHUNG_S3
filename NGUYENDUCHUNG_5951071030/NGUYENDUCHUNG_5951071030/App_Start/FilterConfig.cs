using System.Web;
using System.Web.Mvc;

namespace NGUYENDUCHUNG_5951071030
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
