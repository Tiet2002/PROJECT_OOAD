using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PROJECT_OOAD
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /* Route for Product*/
            routes.MapRoute(
               name: "Product",
               url: "Product",
               defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "ProductCreate",
               url: "ProductCreate",
               defaults: new { controller = "Product", action = "Create", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "ProductEdit",
               url: "ProductEdit-{id}",
               defaults: new { controller = "Product", action = "Edit", id = UrlParameter.Optional }
           );

            /* Route for Product*/
            routes.MapRoute(
               name: "Sale",
               url: "Sale",
               defaults: new { controller = "Sale", action = "Index", id = UrlParameter.Optional }
           );

            /* Default route home */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
