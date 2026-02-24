using Core.Enums;

namespace Core.Entities;

public class Document
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid FileId { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public long? FileSize { get; set; }
    public string? MimeType { get; set; }
    public DocumentType DocumentType { get; set; } = DocumentType.Other;
    public Guid UploadedBy { get; set; }
    public bool IsVisibleToClient { get; set; } = true;
    public DocumentCategory Category { get; set; }
    public string? Description { get; set; }
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }
}
