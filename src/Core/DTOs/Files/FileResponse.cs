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
}
