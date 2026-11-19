using System.Threading.Tasks;
using OP_API.Models;

namespace OP_API.Services;

public interface IDialogueService
{
    Task<InterrogationTurnResponse> ProcessTurnAsync(SuspectContext context, string playerInput);
    SuspectContext CreateInitialContext();
}
