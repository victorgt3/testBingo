using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestBingo.Startup))]
namespace TestBingo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
