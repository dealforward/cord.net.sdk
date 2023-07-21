using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class ThreadParticipants
{
    [JsonProperty("lastSeenTimestamp")] public string? LastSeenTimestamp { get; set; }
    [JsonProperty("userID")] public string? UserId { get; set; }
}