using System.Web.Http;

namespace Store.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "Api/{controller}/{action}/{id}",
                new { action = "Get", id = RouteParameter.Optional }
            );
        }
    }
}
