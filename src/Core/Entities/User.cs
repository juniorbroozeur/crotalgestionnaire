using Core.Enums;

namespace Core.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string? PasswordHash { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public UserRole Role { get; set; }
    public AuthProvider AuthProvider { get; set; } = AuthProvider.Local;
    public string? GoogleId { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsEmailVerified { get; set; }
    public DateTime? LastLoginAt { get; set; }

    public AdminPermission? AdminPermission { get; set; }
    public ICollection<File> ClientFiles { get; set; } = new List<File>();
    public ICollection<File> AssignedFiles { get; set; } = new List<File>();
    public ICollection<Document> UploadedDocuments { get; set; } = new List<Document>();
    public ICollection<Appointment> ClientAppointments { get; set; } = new List<Appointment>();
    public ICollection<Appointment> AdminAppointments { get; set; } = new List<Appointment>();
    public ICollection<Message> SentMessages { get; set; } = new List<Message>();
    public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    public ICollection<Activity> Activities { get; set; } = new List<Activity>();
}
