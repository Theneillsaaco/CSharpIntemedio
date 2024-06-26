﻿using System.Linq.Expressions;

namespace Restaurante.Domain.Core.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> Get(int id);

        Task Save(TEntity entity);

        Task Save(List<TEntity> entities);

        Task Update(TEntity entity);
        
        Task Update(List<TEntity> entities);

        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);

        Task Delete(TEntity entity);
    }
}
