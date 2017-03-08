using System.Web;
using System.Web.Mvc;

namespace DenticonApi_SampleCode
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
