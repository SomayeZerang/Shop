﻿using System.Data.Entity;
using Shop.Data.Context;
using StructureMap;

namespace Shop.IoC
{
    public class DbContextRegistery : Registry
    {
        public DbContextRegistery()
        {
            For<IUnitOfWork>().Use("ShopDbContext");

            For<ShopDbContext>().Use("IUnitOfWork");

            For<DbContext>().Use("IUnitOfWork");
        }
    }
}