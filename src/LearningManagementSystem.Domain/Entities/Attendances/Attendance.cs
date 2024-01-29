namespace LearningManagementSystem.Domain.Entities;

public class Attendance : Auditable
{
    public long StudentId { get; set; }
    public virtual Student Student { get; set; } = new Student();
    public long LessonId { get; set; }
    public virtual Lesson Lesson { get; set; } = new Lesson();
    public bool IsAbsent { get; set; } = false;
    public string Description { get; set; } = string.Empty;
}
