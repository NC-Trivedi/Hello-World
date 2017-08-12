using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCT_Web.Startup))]
namespace NCT_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
