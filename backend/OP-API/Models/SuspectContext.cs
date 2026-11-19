using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OP_API.Models;

public class SuspectContext
{
    [JsonPropertyName("info")]
    public string Info { get; set; } = "Wciel się w rolę suspecta.";

    [JsonPropertyName("suspect_id")]
    public string SuspectId { get; set; } = "";

    [JsonPropertyName("suspect_name")]
    public string SuspectName { get; set; } = "";

    [JsonPropertyName("suspect_surname")]
    public string SuspectSurname { get; set; } = "";

    [JsonPropertyName("suspect_alias")]
    public string SuspectAlias { get; set; } = "";

    [JsonPropertyName("suspect_age")]
    public int SuspectAge { get; set; }

    [JsonPropertyName("suspect_social_status")]
    public string SuspectSocialStatus { get; set; } = "";

    [JsonPropertyName("suspect_description")]
    public string SuspectDescription { get; set; } = "";

    [JsonPropertyName("suspect_military_record")]
    public string SuspectMilitaryRecord { get; set; } = "";

    [JsonPropertyName("suspect_police_record")]
    public string SuspectPoliceRecord { get; set; } = "";

    [JsonPropertyName("suspect_known_vices")]
    public List<string> SuspectKnownVices { get; set; } = new();

    [JsonPropertyName("suspect_interrogation_notes")]
    public string SuspectInterrogationNotes { get; set; } = "";

    [JsonPropertyName("bdi_state")]
    public BdiState BdiState { get; set; } = new();

    [JsonPropertyName("recent_turns")]
    public List<TurnHistory> RecentTurns { get; set; } = new();

    [JsonPropertyName("evidence_on_desk")]
    public EvidenceItem? EvidenceOnDesk { get; set; }

    [JsonPropertyName("player_input")]
    public string PlayerInput { get; set; } = "";
}

public class BdiState
{
    [JsonPropertyName("beliefs")]
    public List<string> Beliefs { get; set; } = new();

    [JsonPropertyName("desires")]
    public List<string> Desires { get; set; } = new();

    [JsonPropertyName("active_intention")]
    public string ActiveIntention { get; set; } = "";

    [JsonPropertyName("trust_tier")]
    public string TrustTier { get; set; } = "";

    [JsonPropertyName("fuzzy_receptivity")]
    public double FuzzyReceptivity { get; set; }

    [JsonPropertyName("evidence_allows_breakthrough")]
    public bool EvidenceAllowsBreakthrough { get; set; }

    [JsonPropertyName("discussed_topics")]
    public List<string> DiscussedTopics { get; set; } = new();
}

public class TurnHistory
{
    [JsonPropertyName("player")]
    public string Player { get; set; } = "";

    [JsonPropertyName("suspect")]
    public string Suspect { get; set; } = "";
}

public class EvidenceItem
{
    [JsonPropertyName("item_id")]
    public string ItemId { get; set; } = "";

    [JsonPropertyName("description")]
    public string Description { get; set; } = "";
}
