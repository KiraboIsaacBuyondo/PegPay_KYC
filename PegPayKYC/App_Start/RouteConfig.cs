using System.Web.Mvc;
using System.Web.Routing;

namespace PegPayKYC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Ignores the route to any resource in the /Content or /Scripts directories, etc.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Custom Route for Client Notifications
            routes.MapRoute(
                name: "ClientNotifications",
                url: "Client/Notifications",
                defaults: new { controller = "Client", action = "ClientNotifications" }
            );

            // Custom Route for Client Status View
            routes.MapRoute(
                name: "ViewStatus",
                url: "Client/Status",
                defaults: new { controller = "Client", action = "ViewStatus" }
            );

            // Custom Route for Adding a Business
            routes.MapRoute(
                name: "AddBusiness",
                url: "Client/AddBusiness",
                defaults: new { controller = "Client", action = "AddBusiness" }
            );

            // Default route for Client Index
            routes.MapRoute(
                name: "Client",
                url: "Client",
                defaults: new { controller = "Client", action = "ClientIndex" }
            );

            // Default route for Client Help
            routes.MapRoute(
                name: "ClientHelp",
                url: "Client/Help",
                defaults: new { controller = "Client", action = "Help" }
            );

            // Default route for Home page
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
