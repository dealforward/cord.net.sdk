using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class CordResponse
{
    [JsonProperty("success")] public bool Success { get; set; }
    [JsonProperty("message")] public string Message { get; set; } = null!;
}