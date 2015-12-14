using KPI.Web.Infrastructure.Security;
using System.Web;
using System.Web.Mvc;

namespace KPI.Web.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
