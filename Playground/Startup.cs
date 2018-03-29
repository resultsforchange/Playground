using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Playground.Startup))]
namespace Playground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
