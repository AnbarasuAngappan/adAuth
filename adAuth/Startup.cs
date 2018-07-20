using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(adAuth.Startup))]
namespace adAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
