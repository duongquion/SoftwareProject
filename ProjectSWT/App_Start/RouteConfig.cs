using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectSWT
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Admin",
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ProjectSWT.Areas.Admin.Controllers" }
            );

            routes.MapRoute(
                name: "Trang chủ",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ProjectSWT.Controllers" }
            );

            routes.MapRoute(
                name: "Su kien",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Event", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ProjectSWT.Controllers" }
            );

            routes.MapRoute(
                name: "Chuyên ngành",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Specialization", action = "Category", id = UrlParameter.Optional },
                namespaces: new string[] { "ProjectSWT.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ProjectSWT.Controllers" }

            );
        }
    }
}
