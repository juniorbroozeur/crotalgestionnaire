using Core.Enums;

namespace Core.Entities;

public class FileActionLog : BaseEntity
{
    public Guid FileId { get; set; }
    public FileActionType ActionType { get; set; }
    public Guid? WorkflowActionId { get; set; }
    public TriggerMethod TriggerMethod { get; set; }
    public Guid TriggeredBy { get; set; }
    public ExecutionStatus Status { get; set; }
    public string? N8nExecutionId { get; set; }
    public string? RequestPayloadJson { get; set; }
    public string? ResponseDataJson { get; set; }
    public string? ErrorMessage { get; set; }
    public int? DurationMs { get; set; }

    public File File { get; set; } = null!;
    public WorkflowAction? WorkflowAction { get; set; }
    public User TriggeredByUser { get; set; } = null!;
}
