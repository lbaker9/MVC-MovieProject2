using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalMovieProject.Startup))]
namespace FinalMovieProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
