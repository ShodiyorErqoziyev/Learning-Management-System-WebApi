namespace LearningManagementSystem.Domain;

public class Human : Auditable
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public bool IsMale { get; set; }
    public string PhoneNumber { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public string Salt { get; set; } = String.Empty;
    public string ImagePath { get; set; } = String.Empty;
    public DateOnly BirthDay { get; set; }
}
