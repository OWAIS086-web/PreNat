using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreNat.Startup))]
namespace PreNat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
