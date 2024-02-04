using LearningManagementSystem.DataAccess.DbContexts;
using LearningManagementSystem.DataAccess.Interfaces;
using LearningManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LearningManagementSystem.DataAccess.Repositories;

public class GenericRepository<Entity> : Repository<Entity>,
    IGenericRepository<Entity> where Entity : BaseEntity
{
     
    public GenericRepository(AppDbContext appDbContext) 
        : base(appDbContext)
    {
    }

    public async Task<Entity?> FirstOrDefaultAsync(Expression<Func<Entity, bool>> expression)
        => await _dbSet.FirstOrDefaultAsync(expression);

    public IQueryable<Entity> GetAll() => _dbSet;

    public async Task<Entity?> LastOrDefaultAsync(Expression<Func<Entity, bool>> expression)
        => await _dbSet.LastOrDefaultAsync(expression);

    public IQueryable<Entity> Where(Expression<Func<Entity, bool>> expression)
        => _dbSet.Where(expression);
}
