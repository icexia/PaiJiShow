using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaiJiShow.Web.Startup))]
namespace PaiJiShow.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
