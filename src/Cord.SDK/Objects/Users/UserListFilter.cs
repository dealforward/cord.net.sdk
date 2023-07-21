using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class UserListFilter
{
    [JsonProperty("metadata")] public object? Metadata { get; set; }
}