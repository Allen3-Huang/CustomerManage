using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerManage.Startup))]
namespace CustomerManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
