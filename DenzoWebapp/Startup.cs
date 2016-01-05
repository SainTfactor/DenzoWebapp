using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DenzoWebapp.Startup))]
namespace DenzoWebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
