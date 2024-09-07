using System.Linq.Expressions;

namespace GerenciadorDeOficios.Domain.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    // Métodos assíncronos
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task SaveAsync();

    // Métodos síncronos
    IEnumerable<TEntity> GetAll();
    TEntity GetById(int id);
    IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void Save();
}