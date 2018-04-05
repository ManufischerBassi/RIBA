using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RIBA_WEB_APP.Startup))]
namespace RIBA_WEB_APP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
