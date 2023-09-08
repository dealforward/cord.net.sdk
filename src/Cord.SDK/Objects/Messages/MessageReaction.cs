using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class MessageReaction
{
    [JsonProperty("reaction")] public string Reaction { get; set; } = null!;
    [JsonProperty("userID")] public string UserId { get; set; } = null!;
    [JsonProperty("timestamp")] public DateTime Timestamp { get; set; }
}