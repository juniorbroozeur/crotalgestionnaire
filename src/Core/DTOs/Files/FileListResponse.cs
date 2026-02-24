namespace Core.DTOs.Files;

public class FileListResponse
{
    public IReadOnlyList<FileResponse> Items { get; set; } = [];
    public int TotalCount { get; set; }
}
