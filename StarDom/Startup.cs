using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarDom.Startup))]
namespace StarDom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
