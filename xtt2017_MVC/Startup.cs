using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xtt2017_MVC.Startup))]
namespace xtt2017_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
