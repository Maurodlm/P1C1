using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCC.Startup))]
namespace MVCC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
