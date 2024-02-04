using LearningManagementSystem.Domain;

namespace LearningManagementSystem.DataAccess.Interfaces;

public interface IRepository <Entity> where Entity : BaseEntity
{
    public void Add (Entity entity);
    public void Update (long id, Entity editedEntity);
    public void Delete (Entity  entity);
    public Task<Entity?> GetByIdAsync (long id);
}
