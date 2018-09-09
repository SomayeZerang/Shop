using System;
using System.Data.Entity;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNet.Identity;
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
            throw new NotImplementedException();
        }

        public Task Register(RegisterUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            _unitOfWork.
        }
    }
}