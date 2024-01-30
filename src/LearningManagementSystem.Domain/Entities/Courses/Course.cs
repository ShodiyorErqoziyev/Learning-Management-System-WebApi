namespace LearningManagementSystem.Domain.Entities;

public class Course : Auditable
{
    public long SubjectId { get; set; }
    public virtual Subject Subject { get; set; } = new Subject();
    public long TeacherId { get; set; }
    public virtual Teacher Teacher { get; set; } = new Teacher();
    public string Status { get; set; } = string.Empty;
    public DateOnly StartAt { get; set; }
    public int LessonCount { get; set; }
    public int StudentCount { get; set; }
    public int MaxCapacity { get; set; }
    public int MinCapacity { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public virtual List<Student> Students { get; set; } = new List<Student>();
    public virtual List<Lesson> Lessons { get; set; } = new List<Lesson>();
}
