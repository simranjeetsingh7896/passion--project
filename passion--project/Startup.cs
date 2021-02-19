using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(passion__project.Startup))]
namespace passion__project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
