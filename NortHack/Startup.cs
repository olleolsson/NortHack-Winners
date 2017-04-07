using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NortHack.Startup))]
namespace NortHack
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
