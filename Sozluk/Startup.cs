using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sozluk.Startup))]
namespace Sozluk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
