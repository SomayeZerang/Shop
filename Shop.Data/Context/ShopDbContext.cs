using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Domain.Identity;

namespace Shop.Data.Context
{
    public class ShopDbContext : IdentityDbContext<User,Role,Guid,UserLogins,UserRoles,UserClaims>, IUnitOfWork

    {
        public void SaveChangeAsync()
        {
            SaveChangeAsync();
        }

        public void SaveChange()
        {
            SaveChange();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
