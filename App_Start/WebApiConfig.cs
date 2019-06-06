using BasicWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace BasicWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            // config.MapHttpAttributeRoutes();

            var constrainResolver = new DefaultInlineConstraintResolver();
            constrainResolver.ConstraintMap.Add("enum", typeof(EnumerationConstraint));
            config.MapHttpAttributeRoutes(constrainResolver);


            //config.Routes.MapHttpRoute(
            //    name: "ProdApi",
            //    routeTemplate: "api/prod/{id}",
            //    defaults: new { controller = "products", id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
