using LearningManagementSystem.Domain;
using System.Linq.Expressions;

namespace LearningManagementSystem.DataAccess.Interfaces;

public interface IGenericRepository<Entity> : IRepository<Entity>
    where Entity : BaseEntity
{
    public IQueryable<Entity> GetAll();
    public IQueryable<Entity> Where(Expression<Func<Entity, bool>> expression);
    public Task<Entity?> FirstOrDefaultAsync(Expression<Func<Entity, bool>> expression);
    public Task<Entity?> LastOrDefaultAsync(Expression<Func<Entity, bool>> expression);
}
