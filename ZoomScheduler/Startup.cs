using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZoomScheduler.Startup))]
namespace ZoomScheduler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
