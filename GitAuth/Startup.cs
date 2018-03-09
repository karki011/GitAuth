using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitAuth.Startup))]
namespace GitAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
