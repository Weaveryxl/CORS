using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CORSTestClient.Startup))]
namespace CORSTestClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
