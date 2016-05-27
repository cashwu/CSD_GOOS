using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testGoos.Startup))]
namespace testGoos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
