using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OoPRestaurant202002.Startup))]
namespace OoPRestaurant202002
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
