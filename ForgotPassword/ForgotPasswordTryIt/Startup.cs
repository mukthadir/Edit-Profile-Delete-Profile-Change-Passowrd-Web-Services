using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForgotPasswordTryIt.Startup))]
namespace ForgotPasswordTryIt
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
