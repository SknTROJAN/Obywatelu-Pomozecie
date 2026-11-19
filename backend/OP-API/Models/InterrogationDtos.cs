namespace OP_API.Models;

public class InterrogationTurnRequest
{
    public SuspectContext? Context { get; set; }
    public string PlayerInput { get; set; } = "";
}

public class InterrogationTurnResponse
{
    public SuspectResponse SuspectResponse { get; set; } = new();
    public SuspectContext UpdatedContext { get; set; } = new();
    public double ResponseTimeSeconds { get; set; }
}
