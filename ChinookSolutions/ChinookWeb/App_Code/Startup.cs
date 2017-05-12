using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChinookWeb.Startup))]
namespace ChinookWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
