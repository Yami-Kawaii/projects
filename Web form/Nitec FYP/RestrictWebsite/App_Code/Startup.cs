using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestrictWebsite.Startup))]
namespace RestrictWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
