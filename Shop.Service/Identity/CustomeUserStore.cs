using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public class CustomeUserStore : UserStore<User,Role,Guid,UserLogins,UserRoles,UserClaims> , ICustomUserStore
    {
        public CustomeUserStore(DbContext context) : base(context)
        {
        }
    }
}