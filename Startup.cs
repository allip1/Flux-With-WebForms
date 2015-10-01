using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormsFluxProto.Startup))]
namespace FormsFluxProto
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
