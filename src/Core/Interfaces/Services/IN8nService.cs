namespace Core.Interfaces.Services;

public interface IN8nService
{
    Task TriggerWorkflowAsync(string workflowKey, object payload, CancellationToken cancellationToken = default);
}
