﻿using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Data.Context;
using Shop.Domain.Identity;

namespace Shop.Service.Identity
{
    public class CustomRoleStore : RoleStore<Role, Guid, UserRoles>, ICustomRoleStore
    {
        public CustomRoleStore(IUnitOfWork context) : base((ShopDbContext) context)
        {
        }
    }
}