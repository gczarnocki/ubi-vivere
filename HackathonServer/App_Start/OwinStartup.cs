using System.IO;
using System.Reflection;
using System.Web.Http;
using HackathonServer;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinStartup))]
namespace HackathonServer
{
    public class OwinStartup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);

            string exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string webFolder = Path.Combine(exeFolder, "/wwwroot/front");
            appBuilder.UseStaticFiles(webFolder);
        }
    }
}
