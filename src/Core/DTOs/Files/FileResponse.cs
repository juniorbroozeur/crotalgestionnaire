using Core.Enums;

namespace Core.DTOs.Files;

public class FileResponse
{
    public Guid Id { get; set; }
    public string FileNumber { get; set; } = string.Empty;
    public Guid ClientId { get; set; }
    public Guid? AssignedAdminId { get; set; }
    public FileStep CurrentStep { get; set; }
    public FileStatus Status { get; set; }
    public string? DestinationCountry { get; set; }
    public string? DestinationUniversity { get; set; }
    public string? ProgramType { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
