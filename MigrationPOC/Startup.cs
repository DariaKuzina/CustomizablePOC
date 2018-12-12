using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MigrationPOC.Startup))]
namespace MigrationPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
