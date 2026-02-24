using Core.DTOs.Files;
using Core.Enums;

namespace Core.Interfaces.Services;

public interface IFileService
{
    Task<FileResponse> CreateAsync(CreateFileRequest request, CancellationToken cancellationToken = default);
    Task<FileResponse?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<FileListResponse> GetByStatusAsync(FileStatus status, CancellationToken cancellationToken = default);
    Task<FileResponse> UpdateAsync(Guid id, UpdateFileRequest request, CancellationToken cancellationToken = default);
    Task ValidateStepAsync(Guid fileId, ValidateStepRequest request, Guid validatedBy, CancellationToken cancellationToken = default);
}
