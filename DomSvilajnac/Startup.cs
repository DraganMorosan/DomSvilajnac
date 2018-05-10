using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DomSvilajnac.Startup))]
namespace DomSvilajnac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
