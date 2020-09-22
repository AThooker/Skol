using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skol.Startup))]
namespace Skol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
