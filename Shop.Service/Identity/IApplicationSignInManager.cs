using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public interface IApplicationSignInManager
    {
        Task SignInAsync(User user, bool isPersistent, bool rememberBrowser);

        Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout);

        Task<SignInStatus> ExternalSignInAsync(ExternalLoginInfo loginInfo, bool isPersistent);
    }
}