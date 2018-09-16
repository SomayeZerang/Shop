using System.Data.Entity;
using Shop.Data.Context;
using StructureMap;

namespace Shop.IoC
{
    public class DbContextRegistery : Registry
    {
        public DbContextRegistery()
        {
            For<IUnitOfWork>().Use<ShopDbContext>();

            For<ShopDbContext>()
                .Use(context => (ShopDbContext)context.GetInstance<IUnitOfWork>());

            For<DbContext>().Use(x => (ShopDbContext)x.GetInstance<IUnitOfWork>());
        }
    }
}