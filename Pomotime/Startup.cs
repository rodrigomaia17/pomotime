using Microsoft.Owin;
using Owin;
using Pomotime;

[assembly: OwinStartup(typeof(Startup))]
namespace Pomotime
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}