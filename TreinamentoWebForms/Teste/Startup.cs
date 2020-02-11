using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teste.Startup))]
namespace Teste
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
