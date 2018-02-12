using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreeConferenceCall_OAuth_Demo.Startup))]
namespace FreeConferenceCall_OAuth_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
