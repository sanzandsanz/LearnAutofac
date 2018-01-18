using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SANZ.AutofacInMVC {
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           // routes.MapRoute(
           //    name: "Default",
           //    url: "{controller}/{action}/{service}",
           //    defaults: new { controller = "Home", action = "Index", service = UrlParameter.Optional }
           //);
        }
    }
}
