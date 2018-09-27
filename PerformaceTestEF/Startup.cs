using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PerformaceTestEF.Startup))]

namespace PerformaceTestEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
