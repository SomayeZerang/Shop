using System;
using System.Threading;
using Shop.Service.Product;
using StructureMap;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Domain.Identity;
using Shop.IoC.Identity;

namespace Shop.IoC.Container
{
    public static class SmObjectFactory
    {
        private static readonly Lazy<StructureMap.Container> Bootstrapper =
            new Lazy<StructureMap.Container>(ContainerDefault, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container => Bootstrapper.Value;

        private static StructureMap.Container ContainerDefault()
        {

            var container = new StructureMap.Container(x =>
            {
                x.Scan(scanner =>
                {
                    scanner.Assembly(typeof(CategoryService).Assembly);
                    scanner.WithDefaultConventions();
                });

                x.AddRegistry<DbContextRegistery>();
                x.AddRegistry<IdentityRegistery>();
            });

            return container;
        }

    }
}