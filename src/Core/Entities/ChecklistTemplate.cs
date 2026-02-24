namespace Core.Entities;

public class ChecklistTemplate : BaseEntity
{
    public string StepName { get; set; } = string.Empty;
    public int StepOrder { get; set; }
    public string? StepLabel { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public bool IsActive { get; set; } = true;
}
