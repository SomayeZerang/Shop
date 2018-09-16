using System;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Domain.Identity;

namespace Shop.Data.Context
{
    public interface IUnitOfWork : IDisposable

    {
        Task SaveChangeAsync();

        Task SaveChange();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        void Added<TEntity>(TEntity entity) where TEntity : class;

        void Modifierd<TEntity>(TEntity entity) where TEntity : class;

        void Deleted<TEntity>(TEntity entity) where TEntity : class;
    }
}