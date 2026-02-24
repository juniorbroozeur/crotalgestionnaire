using Core.Enums;

namespace Core.Entities;

public class EmailQueue : BaseEntity
{
    public Guid? FileId { get; set; }
    public string ToEmail { get; set; } = string.Empty;
    public string? ToName { get; set; }
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public Guid? TemplateId { get; set; }
    public QueueStatus Status { get; set; } = QueueStatus.Pending;
    public TriggerMethod SendMethod { get; set; } = TriggerMethod.Automatic;
    public int RetryCount { get; set; }
    public int MaxRetries { get; set; } = 3;
    public DateTime? SentAt { get; set; }
    public string? ErrorMessage { get; set; }

    public File? File { get; set; }
    public EmailTemplate? Template { get; set; }
}
