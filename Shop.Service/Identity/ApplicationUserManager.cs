using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Cookies;
using Shop.Data.Context;
using Shop.Domain.Identity;
using Shop.Service.Dtos.User;

namespace Shop.Service.Identity
{
    public class ApplicationUserManager : UserManager<User, Guid>, IApplicationUserManager
    {
        private readonly IMapper _mapper;
        private readonly IDbSet<User> _users;
        private readonly IUnitOfWork _unitOfWork;       

        public ApplicationUserManager(IUserStore<User, Guid> store, IMapper mapper, IUnitOfWork unitOfWork) : base(store)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _users = _unitOfWork.Set<User>();
        }

        public Func<CookieValidateIdentityContext, Task> OnValidateIdentity()
        {
            return SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, User, Guid>
            (TimeSpan.FromMinutes(1), (manager, user) => GenerateUserIdentityAsync(user),
                identity => Guid.Parse(identity.GetUserId()));
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(User user)
        {
            var claimsIdentity = CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            return claimsIdentity;
        }

        public Task RegisterAsync(RegisterUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            _unitOfWork.Added(user);

            return _unitOfWork.SaveChangeAsync();
        }
    }
}