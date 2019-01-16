using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftmatDesk.Startup))]
namespace SoftmatDesk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
