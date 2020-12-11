using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiveStudio.Startup))]
namespace HiveStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
