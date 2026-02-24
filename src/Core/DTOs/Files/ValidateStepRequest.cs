using Core.Enums;

namespace Core.DTOs.Files;

public class ValidateStepRequest
{
    public FileStep Step { get; set; }
    public StepAction Action { get; set; }
    public string? Comment { get; set; }
}
