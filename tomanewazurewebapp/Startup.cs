using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tomanewazurewebapp.Startup))]
namespace tomanewazurewebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
