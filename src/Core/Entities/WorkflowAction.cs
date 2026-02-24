namespace Core.Entities;

public class WorkflowAction : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string WorkflowKey { get; set; } = string.Empty;
    public string N8nWebhookUrl { get; set; } = string.Empty;
    public string? TriggerEvent { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;
}
