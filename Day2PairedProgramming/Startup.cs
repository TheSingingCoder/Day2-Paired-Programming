using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day2PairedProgramming.Startup))]
namespace Day2PairedProgramming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
