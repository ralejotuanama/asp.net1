using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hola_mundo_web.Startup))]
namespace hola_mundo_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
