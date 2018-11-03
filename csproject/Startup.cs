using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(csproject.Startup))]
namespace csproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
