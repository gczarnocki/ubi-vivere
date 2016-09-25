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
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
            );

            app.UseWebApi(config);

            string exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string webFolder = Path.Combine(exeFolder, "/wwwroot/front");
            app.UseStaticFiles(webFolder);
        }
    }
}
