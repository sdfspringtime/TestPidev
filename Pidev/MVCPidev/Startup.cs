using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPidev.Startup))]
namespace MVCPidev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
