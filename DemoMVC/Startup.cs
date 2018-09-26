using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoMVC.Startup))]
namespace DemoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
