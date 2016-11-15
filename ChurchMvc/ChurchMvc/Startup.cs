using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChurchMvc.Startup))]
namespace ChurchMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
