using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_NguyenLeHongQuang.Startup))]
namespace Lab2_NguyenLeHongQuang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
