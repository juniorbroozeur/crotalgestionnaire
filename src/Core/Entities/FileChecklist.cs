namespace Core.Entities;

public class FileChecklist : BaseEntity
{
    public Guid FileId { get; set; }
    public string StepName { get; set; } = string.Empty;
    public int StepOrder { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }
    public Guid? CompletedBy { get; set; }
    public string? Notes { get; set; }

    public File File { get; set; } = null!;
    public User? CompletedByUser { get; set; }
}
