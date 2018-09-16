using System;
using AutoMapper;
using Shop.Service.Mapping;

namespace Shop.Service.Dtos.User
{
    public class RegisterUserDto : BaseDto<Guid> , IMapping
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public void CreateMapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<Domain.Identity.User, RegisterUserDto>(MemberList.None);
        }
    }
}