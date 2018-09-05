using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Domain.Identity;
using Shop.Service.Identity;
using StructureMap;

namespace Shop.IoC.Identity
{
    public class IdentityRegistery : Registry
    {
        public IdentityRegistery()
        {
            For<IUserStore<User, Guid>>().Use<UserStore<User, Role, Guid, UserLogins, UserRoles, UserClaims>>();
            For<ICustomRoleStore>().Use("CustomRoleStore");
            For<ICustomUserStore>().Use("CustomUserStore");
        }
    }
}