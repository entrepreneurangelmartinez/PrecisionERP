using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolutionERP.Startup))]
namespace SolutionERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
