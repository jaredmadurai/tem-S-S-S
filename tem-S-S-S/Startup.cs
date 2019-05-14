using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tem_S_S_S.Startup))]
namespace tem_S_S_S
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
