using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TimKiemViecLam
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "TinViecLam",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TinViecLam", action = "DetailIndex", id = UrlParameter.Optional }
            );
        }
    }
}
