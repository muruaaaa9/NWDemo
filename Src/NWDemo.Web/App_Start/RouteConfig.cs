using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NWDemo.Web
{
    public class RouteConfig
    {
       
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapHttpRoute(name: ControllerAndId,
            //    routeTemplate: "api/{controller}/{id}",
            //    default:null,
            //    constraints: new { id= @"^\d+$"}
            //    );

           
        }
    }
}