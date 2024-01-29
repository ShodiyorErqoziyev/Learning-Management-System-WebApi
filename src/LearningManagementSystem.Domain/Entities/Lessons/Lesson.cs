namespace LearningManagementSystem.Domain.Entities;

public class Lesson : Auditable
{
    public long CourseId { get; set; }
    public virtual Course Course { get; set; } = new Course();
    public string Theme { get; set; } = string.Empty;
    public string? Content { get; set; } = null;
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int Duration { get; set; }
    public virtual List<Attendance> Attendances { get; set; } = new List<Attendance>();
}
