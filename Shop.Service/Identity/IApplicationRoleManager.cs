using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public interface IApplicationRoleManager
    {
        Task<IdentityResult> CreateAsync(Role role);

        Task<IdentityResult> UpdateAsync(Role role);

        Task<bool> RoleExistsAsync(string roleName);

        Task<Role> FindByNameAsync(string roleName);

        Task<List<Role>> GetRolesAsync();

        void Seed();
    }
}