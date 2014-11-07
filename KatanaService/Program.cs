using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;
using Microsoft.Owin.Hosting;

namespace KatanaService
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Katana service has been started.");
                Console.WriteLine("Press any key to stop the service...");
                Console.ReadKey();
                Console.WriteLine("Katana service has been stopped.");
            }
        }

        public class Startup
        {
            public void Configuration(IAppBuilder app)
            {
               ConfigureWebApi(app);
            }

            private void ConfigureWebApi(IAppBuilder app)
            {
                var config = new HttpConfiguration();

                config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });

                app.UseWebApi(config);
            }
        }
    }
}
