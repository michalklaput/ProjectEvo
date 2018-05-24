using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectEvo.Startup))]
namespace ProjectEvo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
