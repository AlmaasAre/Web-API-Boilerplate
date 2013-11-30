﻿using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Boilerplate
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            //Disable XML support, rmove as needed.
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(m => m.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

            var cors = new EnableCorsAttribute("*", "*", "*"); //Enable CORS globally
            config.EnableCors();
        }
    }
}