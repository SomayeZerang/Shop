using System;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Xml;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Domain.Identity;

namespace Shop.Data.Context
{
    public interface IUnitOfWork

    {
        void SaveChangeAsync();

        void SaveChange();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        void Added<TEntity>(TEntity entity) where TEntity : class;

        void Modifierd<TEntity>(TEntity entity) where TEntity : class;

        void Deleted<TEntity>(TEntity entity) where TEntity : class;
    }
}