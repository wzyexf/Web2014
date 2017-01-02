using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Design2014.Startup))]
namespace Design2014
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
