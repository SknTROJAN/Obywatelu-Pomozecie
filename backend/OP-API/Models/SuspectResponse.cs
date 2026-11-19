using System.Text.Json.Serialization;

namespace OP_API.Models;

public class SuspectResponse
{
    [JsonPropertyName("dialogue_text")]
    public string DialogueText { get; set; } = "";

    [JsonPropertyName("semantic_analysis")]
    public SemanticAnalysis? SemanticAnalysis { get; set; }

    [JsonPropertyName("visual_cue")]
    public string VisualCue { get; set; } = "";
}

public class SemanticAnalysis
{
    [JsonPropertyName("player_approach")]
    public string PlayerApproach { get; set; } = "";

    [JsonPropertyName("suspect_reaction")]
    public string SuspectReaction { get; set; } = "";

    [JsonPropertyName("bribe_attempt_detected")]
    public bool BribeAttemptDetected { get; set; }

    [JsonPropertyName("bdi_intention_shift")]
    public string BdiIntentionShift { get; set; } = "";
}
