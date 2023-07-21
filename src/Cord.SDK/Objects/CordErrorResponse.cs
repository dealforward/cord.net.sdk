using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class CordErrorResponse
{
    [JsonProperty("error")] public string Error { get; set; } = null!;
    [JsonProperty("message")] public string Message { get; set; } = null!;
}