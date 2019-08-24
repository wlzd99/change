using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(change.Startup))]
namespace change
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
