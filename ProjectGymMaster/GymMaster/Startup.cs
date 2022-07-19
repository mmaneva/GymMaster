using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymMaster.Startup))]
namespace GymMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
