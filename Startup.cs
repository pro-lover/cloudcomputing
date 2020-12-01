using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cloudcomputing.Startup))]
namespace cloudcomputing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
