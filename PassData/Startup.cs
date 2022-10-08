using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassData.Startup))]
namespace PassData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
