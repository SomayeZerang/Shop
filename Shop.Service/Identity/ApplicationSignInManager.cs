using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public class ApplicationSignInManager : SignInManager<User, Guid>, IApplicationSignInManager
    {
        public ApplicationSignInManager(UserManager<User, Guid> userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager)
        {
        }
    }
}