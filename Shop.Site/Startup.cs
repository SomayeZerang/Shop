using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using Shop.IoC.Container;

[assembly: OwinStartup(typeof(Shop.Site.Startup))]

namespace Shop.Site
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            ConfigureAuth(app);
        }

        private static void ConfigureAuth(IAppBuilder app)
        {
            //SmObjectFactory.Container.Configure(c =>
            //    {
            //        c.For<IDataProtectionProvider>.Use(() => app.GetDataProtectionProvider());
            //    });
        }
    }
}
