namespace LearningManagementSystem.Domain;

public class Auditable : BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set;}
}
