using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LordsOfBaltimore.Startup))]
namespace LordsOfBaltimore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
