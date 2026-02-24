using Core.Enums;

namespace Core.Entities;

public class EmailTemplate : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string TemplateKey { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public EmailCategory Category { get; set; }
    public string? VariablesJson { get; set; }
    public bool IsActive { get; set; } = true;
    public Guid CreatedBy { get; set; }

    public User Creator { get; set; } = null!;
}
