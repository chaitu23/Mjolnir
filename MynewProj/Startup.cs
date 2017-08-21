using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MynewProj.Startup))]
namespace MynewProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
