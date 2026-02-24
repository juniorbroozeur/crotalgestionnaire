using Core.DTOs.Files;
using Core.Enums;
using Microsoft.AspNetCore.Mvc;

namespace AdminApi.Controllers;

[ApiController]
[Route("api/files")]
[Produces("application/json")]
public class FilesController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(FileListResponse), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new FileListResponse
        {
            Items =
            [
                new FileResponse
                {
                    Id = Guid.NewGuid(),
                    FileNumber = "ETU-2026-001",
                    ClientId = Guid.NewGuid(),
                    AssignedAdminId = Guid.NewGuid(),
                    CurrentStep = FileStep.Admission,
                    Status = FileStatus.EnProcedure,
                    DestinationCountry = "France",
                    DestinationUniversity = "Université Paris Cité",
                    ProgramType = "Master",
                    CreatedAt = DateTime.UtcNow.AddDays(-12),
                    UpdatedAt = DateTime.UtcNow
                }
            ],
            TotalCount = 1
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(FileResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] CreateFileRequest request)
    {
        if (request.ClientId == Guid.Empty)
        {
            return BadRequest("ClientId est obligatoire.");
        }

        var created = new FileResponse
        {
            Id = Guid.NewGuid(),
            FileNumber = $"ETU-{DateTime.UtcNow.Year}-TMP",
            ClientId = request.ClientId,
            AssignedAdminId = request.AssignedAdminId,
            CurrentStep = FileStep.Creation,
            Status = FileStatus.EnAttente,
            DestinationCountry = request.DestinationCountry,
            DestinationUniversity = request.DestinationUniversity,
            ProgramType = request.ProgramType,
            StartDate = request.StartDate,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        return CreatedAtAction(nameof(GetAll), created);
    }

    [HttpPost("{id:guid}/validate-step")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ValidateStep(Guid id, [FromBody] ValidateStepRequest request)
    {
        if (id == Guid.Empty)
        {
            return BadRequest("Id dossier invalide.");
        }

        return NoContent();
    }
}
