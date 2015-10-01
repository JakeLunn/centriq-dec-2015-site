using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(centriq_dec_2015_site.Startup))]
namespace centriq_dec_2015_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
