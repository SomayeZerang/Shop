using System;
using Microsoft.AspNet.Identity;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public class ApplicationRoleManager : RoleManager<Role, Guid> , IApplicationRoleManager
    {
        public ApplicationRoleManager(IRoleStore<Role, Guid> store) : base(store)
        {
        }
    }
}