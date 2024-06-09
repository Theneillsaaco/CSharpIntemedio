using System.Linq.Expressions;
using AdminDepartamentos.Domain.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminDepartament.Infrastucture.Core;

/// <summary>
/// Clase Base de los Repository.
/// </summary>
/// <typeparam name="TEntity">Cambiar "TEntity" por su Clase.</typeparam>
public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity: class
{
    #region Context

    private readonly DbContext _context;
    private DbSet<TEntity> _entities;
    
    protected BaseRepository(DbContext context)
    {
        this._context = context;
        this._entities = this._context.Set<TEntity>();
    }

    #endregion

    
    public virtual async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
    {
        return await _entities.Where(filter).ToListAsync();
    }

    public virtual async Task<TEntity> Get(int id)
    {
        return await _entities.FindAsync(id);
    }

    public virtual async Task Save(TEntity entity)
    {
        this._entities.Add(entity);
        await this._context.SaveChangesAsync();
    }

    public virtual async Task Update(TEntity entity, int id)
    {
        this._entities.Update(entity);
        await this._context.SaveChangesAsync();
    }

    public virtual async Task Deleted(TEntity entity, int id)
    {
        this._entities.Update(entity);
        await this._context.SaveChangesAsync();
    }

    public virtual async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
    {
        return await this._entities.AnyAsync(filter);
    }
}