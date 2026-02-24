using Core.Entities;
using Core.Enums;

namespace Core.Interfaces.Repositories;

public interface IFileRepository : IGenericRepository<File>
{
    Task<File?> GetByFileNumberAsync(string fileNumber, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<File>> GetByStatusAsync(FileStatus status, CancellationToken cancellationToken = default);
}
