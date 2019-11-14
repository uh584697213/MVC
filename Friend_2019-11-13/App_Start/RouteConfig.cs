using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Friend_2019_11_13
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MacRoute",
                url: "Mac",
                defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "iPadRoute",
                url: "iPad",
                defaults: new { controller = "iPad", action = "MacPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "iPhoneRoute",
                url: "iPhone",
                defaults: new { controller = "iPhone", action = "MacPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "WatchRoute",
                url: "Watch",
                defaults: new { controller = "Watch", action = "MacPage", id = UrlParameter.Optional }
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
