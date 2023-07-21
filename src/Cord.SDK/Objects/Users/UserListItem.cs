using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class UserListItem
{
    [JsonProperty("id")] public string Id { get; set; } = null!;
    [JsonProperty("name")] public string? Name { get; set; }
    [JsonProperty("email")] public string? Email { get; set; }
}