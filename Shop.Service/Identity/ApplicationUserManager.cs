using System;
using Microsoft.AspNet.Identity;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public class ApplicationUserManager : UserManager<User, Guid>, IApplicationUserManager
    {
        public ApplicationUserManager(IUserStore<User, Guid> store) : base(store)
        {
        }
    }
}