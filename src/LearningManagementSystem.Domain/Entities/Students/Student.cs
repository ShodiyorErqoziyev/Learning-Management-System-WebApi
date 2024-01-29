namespace LearningManagementSystem.Domain.Entities;

public class Student : Human
{
    public virtual List<Course> Courses { get; set; } = new List<Course>();
}
