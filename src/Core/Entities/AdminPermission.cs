namespace Core.Entities;

public class AdminPermission : BaseEntity
{
    public Guid UserId { get; set; }
    public bool CanCreateFile { get; set; }
    public bool CanValidateStep { get; set; }
    public bool CanSendEmail { get; set; }
    public bool CanManageUsers { get; set; }
    public bool CanViewAllFiles { get; set; }
    public bool CanManageTemplates { get; set; }
    public bool CanManageWorkflows { get; set; }

    public User User { get; set; } = null!;
}
