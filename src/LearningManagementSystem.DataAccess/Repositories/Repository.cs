using LearningManagementSystem.DataAccess.DbContexts;
using LearningManagementSystem.DataAccess.Interfaces;
using LearningManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace LearningManagementSystem.DataAccess.Repositories;

public class Repository<T> : IRepository<T>
    where T : BaseEntity
{
    protected readonly DbSet<T> _dbSet;

    public Repository(AppDbContext appDbContext)
    {
        this._dbSet = appDbContext.Set<T>();
    }

    public void Add(T entity) => _dbSet.Add(entity);

    public void Delete(T entity) => _dbSet.Remove(entity);

    public void Update(long id, T editedEntity)
    {
        editedEntity.Id = id;
        _dbSet.Update(editedEntity);
    }
    public async Task<T?> GetByIdAsync(long id)
        => await _dbSet.FindAsync(id);

}
