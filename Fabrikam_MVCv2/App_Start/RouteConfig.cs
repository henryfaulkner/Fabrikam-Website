using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fabrikam_MVCv2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                name: "Admin",
                url: "Admin",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
                );
            
            routes.MapRoute(
                name: "Law",
                url: "Law",
                defaults: new { controller = "Index", action = "Law", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Education",
                url: "Education",
                defaults: new { controller = "Index", action = "Education", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Music",
                url: "Music",
                defaults: new { controller = "Index", action = "Music", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Computing_Digital_Music",
                url: "Computing_Digital_Music",
                defaults: new { controller = "Index", action = "Computing_Digital_Music", id = UrlParameter.Optional }
            );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
