namespace LearningManagementSystem.Domain.Entities;

public class Subject : Auditable
{
    public decimal Price { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public virtual List<Course> Courses { get; set; } = new List<Course>();
}
