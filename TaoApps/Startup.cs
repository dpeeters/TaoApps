using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaoApps.Startup))]
namespace TaoApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
