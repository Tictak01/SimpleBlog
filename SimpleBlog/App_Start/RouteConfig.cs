using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Keeps the Areas controller with similar names under control
            var namespaces = new[] { typeof (PostsController).Namespace}; //Doing something with the namespaces and turning it into a string.  Honestly, this needs review

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //removed default routes

            //Home page route
            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces);

            //Login route
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces);
        }
    }
}
