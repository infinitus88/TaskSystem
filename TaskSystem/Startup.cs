using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskSystem.Startup))]
namespace TaskSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
