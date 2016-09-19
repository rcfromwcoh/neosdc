using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(neosdcv1.Startup))]
namespace neosdcv1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
