using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LojaSistema2.Startup))]
namespace LojaSistema2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
