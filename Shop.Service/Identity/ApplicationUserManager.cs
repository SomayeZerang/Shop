using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Shop.Domain.Identity;
using Shop.Service.Dtos.User;

namespace Shop.Service.Identity
{
    public class ApplicationUserManager : UserManager<User, Guid>, IApplicationUserManager
    {
        public ApplicationUserManager(IUserStore<User, Guid> store) : base(store)
        {
        }

        public Func<CookieValidateIdentityContext, Task> OnValidateIdentity()
        {
            throw new NotImplementedException();
        }

        public Task Register(RegisterUserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}