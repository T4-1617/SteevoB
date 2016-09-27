using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_160927Webb.Startup))]
namespace _160927Webb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
