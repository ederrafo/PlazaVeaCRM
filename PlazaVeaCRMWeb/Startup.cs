using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlazaVeaCRMWeb.Startup))]
namespace PlazaVeaCRMWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
