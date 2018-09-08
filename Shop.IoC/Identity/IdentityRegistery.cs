using System;
using System.Net.Http;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Shop.Domain.Identity;
using StructureMap;

namespace Shop.IoC.Identity
{
    public class IdentityRegistery : Registry
    {
        public IdentityRegistery()
        {
            For<IUserStore<User, Guid>>().Use<UserStore<User, Role, Guid, UserLogins, UserRoles, UserClaims>>();
            //For<ICustomRoleStore>().Use("CustomRoleStore");
           // For<ICustomUserStore>().Use("CustomUserStore");

            For<IAuthenticationManager>().Use(() => HttpContext.Current.GetOwinContext().Authentication);
        }
    }
}