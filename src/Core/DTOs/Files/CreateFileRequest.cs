namespace Core.DTOs.Files;

public class CreateFileRequest
{
    public Guid ClientId { get; set; }
    public Guid? AssignedAdminId { get; set; }
    public string? DestinationCountry { get; set; }
    public string? DestinationUniversity { get; set; }
    public string? ProgramType { get; set; }
    public DateOnly? StartDate { get; set; }
    public string? Notes { get; set; }
}
