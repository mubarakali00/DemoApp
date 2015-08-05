using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoApp.Client.Startup))]
namespace DemoApp.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
