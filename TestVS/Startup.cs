using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestVS.Startup))]
namespace TestVS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
          
        }
    }
}
