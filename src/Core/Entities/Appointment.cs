using Core.Enums;

namespace Core.Entities;

public class Appointment : BaseEntity
{
    public Guid ClientId { get; set; }
    public Guid AdminId { get; set; }
    public Guid? FileId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public int DurationMinutes { get; set; } = 30;
    public string? Location { get; set; }
    public MeetingType MeetingType { get; set; }
    public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
    public string? Notes { get; set; }
    public string? CancellationReason { get; set; }
    public bool ReminderSent { get; set; }

    public User Client { get; set; } = null!;
    public User Admin { get; set; } = null!;
    public File? File { get; set; }
}
