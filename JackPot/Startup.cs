using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JackPot.Startup))]
namespace JackPot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
