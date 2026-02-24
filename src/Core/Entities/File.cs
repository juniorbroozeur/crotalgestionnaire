using Core.Enums;

namespace Core.Entities;

public class File : BaseEntity
{
    public string FileNumber { get; set; } = string.Empty;
    public Guid ClientId { get; set; }
    public Guid? AssignedAdminId { get; set; }
    public FileStep CurrentStep { get; set; } = FileStep.Creation;
    public FileStatus Status { get; set; } = FileStatus.EnAttente;
    public string? DestinationCountry { get; set; }
    public string? DestinationUniversity { get; set; }
    public string? ProgramType { get; set; }
    public DateOnly? StartDate { get; set; }
    public string? Notes { get; set; }
    public DateTime? FinalizedAt { get; set; }

    public User Client { get; set; } = null!;
    public User? AssignedAdmin { get; set; }
}
