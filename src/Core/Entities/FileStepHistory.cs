using Core.Enums;

namespace Core.Entities;

public class FileStepHistory : BaseEntity
{
    public Guid FileId { get; set; }
    public FileStep Step { get; set; }
    public StepAction Action { get; set; }
    public Guid ValidatedBy { get; set; }
    public string? Comment { get; set; }
    public string? AttachmentsJson { get; set; }

    public File File { get; set; } = null!;
    public User ValidatedByUser { get; set; } = null!;
}
