using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_28Mar.Startup))]
namespace _28Mar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
