using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KeirseySorter.Startup))]
namespace KeirseySorter
{
    public partial class Startup //123
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
