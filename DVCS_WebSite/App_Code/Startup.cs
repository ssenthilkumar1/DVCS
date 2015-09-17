using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVCS_WebSite.Startup))]
namespace DVCS_WebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
