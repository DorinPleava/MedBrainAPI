﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MedBrain
{
    public static class WebApiConfig
    {
        public const string DEFAULT_ROUTE_NAME = "MyDefaultRoute";
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
