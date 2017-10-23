using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jenkins_web_app.Startup))]
namespace Jenkins_web_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
