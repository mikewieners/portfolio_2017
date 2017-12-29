using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portfolio_2017.UI.Startup))]
namespace portfolio_2017.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
