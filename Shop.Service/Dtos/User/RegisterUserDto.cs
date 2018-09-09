using System;
using AutoMapper;

namespace Shop.Service.Dtos.User
{
    public class RegisterUserDto : BaseDto<Guid>
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}