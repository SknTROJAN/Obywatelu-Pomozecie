using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OP_API.Models;
using OP_API.Services;

namespace OP_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InterrogationController : ControllerBase
{
    private readonly IDialogueService _dialogueService;
    private readonly ILogger<InterrogationController> _logger;

    public InterrogationController(IDialogueService dialogueService, ILogger<InterrogationController> logger)
    {
        _dialogueService = dialogueService;
        _logger = logger;
    }

    // Pobiera kontekst podejrzanego
    [HttpGet("initial-context")]
    public ActionResult<SuspectContext> GetInitialContext()
    {
        var context = _dialogueService.CreateInitialContext();
        return Ok(context);
    }

    // Endpoint do gadania z AI
    [HttpPost("turn")]
    public async Task<ActionResult<InterrogationTurnResponse>> ProcessTurn([FromBody] InterrogationTurnRequest request)
    {
        if (request == null)
        {
            return BadRequest("Brak ciała żądania (request body).");
        }

        if (string.IsNullOrWhiteSpace(request.PlayerInput))
        {
            return BadRequest("Kwestia gracza ('playerInput') nie może być pusta.");
        }

        try
        {
            var context = request.Context ?? _dialogueService.CreateInitialContext();
            var response = await _dialogueService.ProcessTurnAsync(context, request.PlayerInput);
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Błąd podczas przetwarzania tury przesłuchania.");
            return StatusCode(500, new { error = ex.Message });
        }
    }
}
