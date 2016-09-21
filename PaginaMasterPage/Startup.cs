using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaginaMasterPage.Startup))]
namespace PaginaMasterPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
