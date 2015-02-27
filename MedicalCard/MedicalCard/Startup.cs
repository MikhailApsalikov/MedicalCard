using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicalCard.Startup))]
namespace MedicalCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
