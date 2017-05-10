using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieArchive.Startup))]
namespace MovieArchive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
