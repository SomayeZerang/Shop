using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using Shop.IoC.Container;
using Shop.Service.Identity;

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
            SmObjectFactory.Container.Configure(c =>
                {
                    c.For<IDataProtectionProvider>().Use(() => app.GetDataProtectionProvider());
                });

            app.CreatePerOwinContext(() => (ApplicationUserManager)SmObjectFactory
                .Container.GetInstance<IApplicationUserManager>());

            app.CreatePerOwinContext(() => (ApplicationRoleManager)SmObjectFactory
                .Container.GetInstance<IApplicationRoleManager>());

            app.CreatePerOwinContext(() => (ApplicationSignInManager)SmObjectFactory
                .Container.GetInstance<IApplicationSignInManager>());


            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                CookieName = "Shop",
                LoginPath = new PathString("/login"),
                ExpireTimeSpan = TimeSpan.FromDays(5),
                CookieDomain = "shop.com",
                Provider = new CookieAuthenticationProvider()
                {
                    OnValidateIdentity = SmObjectFactory.Container
                        .GetInstance<IApplicationUserManager>().OnValidateIdentity()
                }
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));
        }
    }
}
