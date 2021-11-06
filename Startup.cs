using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotNetF_MembershipApp.Startup))]
namespace dotNetF_MembershipApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
