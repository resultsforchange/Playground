using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WizardWebTester.Startup))]
namespace WizardWebTester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
