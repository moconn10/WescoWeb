using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WescoWeb.Startup))]
namespace WescoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
