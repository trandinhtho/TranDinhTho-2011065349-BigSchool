using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranDinhTho_2011065349.Startup))]
namespace TranDinhTho_2011065349
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
