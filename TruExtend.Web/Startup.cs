using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruExtend.Web.Startup))]
namespace TruExtend.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
