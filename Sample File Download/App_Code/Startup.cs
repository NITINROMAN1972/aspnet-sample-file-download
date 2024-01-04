using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_File_Download.Startup))]
namespace Sample_File_Download
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
