using System.Web;
using System.Web.Mvc;

namespace DWEB514_Elie_Atamech
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
