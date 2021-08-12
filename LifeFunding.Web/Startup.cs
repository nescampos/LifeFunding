using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeFunding.Web.Startup))]
namespace LifeFunding.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
