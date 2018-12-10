using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RanaSchool.web.Startup))]
namespace RanaSchool.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
