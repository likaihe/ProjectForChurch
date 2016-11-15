using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ChurchMvc
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
                name: "MultipleApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //    name: "MultipleApiWithouId",
            //    routeTemplate: "api/{controller}/{action}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
