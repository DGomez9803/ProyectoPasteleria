using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ProyectoPasteleria.StartupOwin))]

namespace ProyectoPasteleria
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
