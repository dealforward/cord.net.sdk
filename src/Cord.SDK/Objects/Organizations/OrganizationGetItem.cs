using Newtonsoft.Json;

namespace Cord.SDK.Objects;
/// <summary>
/// Represents the HTTP request result for the organization detail.
/// </summary>
public sealed class OrganizationGetItem
{
    [JsonProperty("id")] public string Id { get; set; } = null!;
    [JsonProperty("name")] public string Name { get; set; } = null!;
    [JsonProperty("members")] public IEnumerable<string>? Members { get; set; }
}