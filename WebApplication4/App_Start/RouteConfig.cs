using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");



            //routes.MapRoute(
            //    name: "Home",
            //    url: "",
            //    defaults: new { controller = "Home", action = "GotoHome", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Home2",
                url: "Home",
                defaults: new { controller = "Home", action = "MyHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home3",
                url: "costumer",
                defaults: new { controller = "Home", action = "FillCostumer", id = UrlParameter.Optional }
            );

        }
    }
}
