using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public interface IApplicationUserManager
    {

        Task<IdentityResult> ChangePasswordAsync(Guid userId, string currentPassword, string newPassword);
        Task<IdentityResult> ChangePhoneNumberAsync(Guid userId, string phoneNumber, string token);

        Func<CookieValidateIdentityContext, Task> OnValidateIdentity();

        //Task<IdentityResult> ResetPasswordAsync(Guid userId, string token, string newPassword);

        //Task<string> GeneratePasswordResetTokenAsync(Guid userId);        

        //Task<IdentityResult> UpdateSecurityStampAsync(Guid userId);

        //Func<CookieValidateIdentityContext, Task> OnValidateIdentity();

        //Task<ClaimsIdentity> GenerateUserIdentityAsync(User user);
        //Task<IdentityResult> AddLoginAsync(Guid userId, UserLoginInfo login);
       
        //Task<bool> IsEmailConfirmedAsync(Guid userId);

        //Task<User> FindByEmailAsync(string email);

        //Task<User> FindByNameAsync(string userName);

        //Task<IdentityResult> CreateAsync(User user, string password);

        //Task<IdentityResult> CreateAsync(User user);

        //Task<IdentityResult> AddClaimAsync(Guid userId, Claim claim);

        //Task<IdentityResult> AddToRoleAsync(Guid userId, string role);

        //Task<string> GenerateEmailConfirmationTokenAsync(Guid userId);

        //Task<IdentityResult> RemoveFromRoleAsync(Guid userId, string role);

        //Task<User> FindAsync(string userName, string password);

        //Task<User> FindAsync(string phoneNumber);

        //Task<User> GetAsync(string userName);

        //Task<User> FindAsync(Guid userId);

        //string GetStringGuidKey(Guid userId);

        //void UpdateUserLastActivityDate(Guid userId);

        //Task<IList<string>> GetRolesAsync(Guid userId);

        //void RegisterTwoFactorProvider(string twoFactorProvider, IUserTokenProvider<User, Guid> provider);

        //Task<string> GenerateChangePhoneNumberTokenAsync(Guid userId, string phoneNumber);

        //void Seed();

        //Task ExpirePlayerIdAsync(Guid userId);

        //Task UpdatePlayerIdAsync(Guid userId, string playerId);

        //Task<string> UpdateAvatarAsync(Guid userId, string imageName);       
        
        //Task<User> FindCustomerAsync(string phoneNumber);
    }
}