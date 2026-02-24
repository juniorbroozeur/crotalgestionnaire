using Core.Enums;

namespace Core.Entities;

public class Activity : BaseEntity
{
    public Guid AdminId { get; set; }
    public Guid? FileId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateOnly? DueDate { get; set; }
    public ActivityStatus Status { get; set; } = ActivityStatus.Todo;
    public ActivityPriority Priority { get; set; } = ActivityPriority.Medium;
    public DateTime? CompletedAt { get; set; }
}
