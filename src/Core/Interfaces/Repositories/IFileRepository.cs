using Core.Enums;
using EntityFile = Core.Entities.File;

namespace Core.Interfaces.Repositories;

public interface IFileRepository : IGenericRepository<EntityFile>
{
    Task<EntityFile?> GetByFileNumberAsync(string fileNumber, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<EntityFile>> GetByStatusAsync(FileStatus status, CancellationToken cancellationToken = default);
}
