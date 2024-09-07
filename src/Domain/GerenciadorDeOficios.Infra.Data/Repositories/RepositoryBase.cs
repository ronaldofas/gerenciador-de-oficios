using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    protected readonly GerenciadorDeOficiosDbContext Context;

    public RepositoryBase(GerenciadorDeOficiosDbContext context)
    {
        Context = context;
    }

    public void Add(TEntity entity)
    {
        Context.Set<TEntity>().Add(entity);
    }

    public async Task AddAsync(TEntity entity)
    {
        await Context.Set<TEntity>().AddAsync(entity);
    }

    public void Delete(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
    }

    public async Task DeleteAsync(TEntity entity)
    {
        await Task.Run(() =>
        {
            Context.Set<TEntity>().Remove(entity);
        });
    }

    public IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
    {
        return Context.Set<TEntity>().Where(expression).ToList();
    }

    public async Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression)
    {
        if (expression == null){
            return Enumerable.Empty<TEntity>();
        }
        
        return await Context.Set<TEntity>().Where(expression).ToListAsync();
    }

    public IEnumerable<TEntity> GetAll()
    {
        return Context.Set<TEntity>().ToList();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await Context.Set<TEntity>().ToListAsync();
    }

    public TEntity GetById(int id)
    {
        var entity = Context.Set<TEntity>().Find(id);
        if (entity == null)
        {
            throw new ArgumentException($"Entidade com ID {id} não localizada.");
        }
        return entity;
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        var entity = await Context.Set<TEntity>().FindAsync(id);
        if (entity == null)
        {
            throw new ArgumentException($"Entidade com ID {id} não localizada.");
        }
        return entity;
    }

    public void Save()
    {
        Context.SaveChanges();
    }

    public async Task SaveAsync()
    {
        await Context.SaveChangesAsync();
    }

    public void Update(TEntity entity)
    {
        Context.Set<TEntity>().Update(entity);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        await Task.Run(() => 
        {
            Context.Set<TEntity>().Update(entity);
        });
    }
}
