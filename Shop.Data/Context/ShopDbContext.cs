using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Domain.Identity;
using Shop.Domain.Product;

namespace Shop.Data.Context
{
    public class ShopDbContext : IdentityDbContext<User,Role,Guid,UserLogins,UserRoles,UserClaims>, IUnitOfWork
    {
        public ShopDbContext(): base("Db_AppShop")
        {
            
        }
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

        public void Added<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Added;
        }

        public void Modifierd<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void Deleted<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Deleted;
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Product> Products { get; set; }
    }
}
