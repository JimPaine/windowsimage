using System.Web.Mvc;
using System.Web.Routing;
using WindowsImage.Additional.Controllers;
using WindowsImage.Controllers;

namespace WindowsImage
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                namespaces: new[] { typeof(HomeController).Namespace, typeof(AnotherController).Namespace },
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
