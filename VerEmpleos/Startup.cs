using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VerEmpleos.Startup))]
namespace VerEmpleos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
