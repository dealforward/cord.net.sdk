using Newtonsoft.Json;

namespace Cord.SDK.Objects;
/// <summary>
/// Represents the result of an HTTP request for the organization list.
/// </summary>
[Obsolete("Please use the group API instead of this.")]
public sealed class OrganizationListItem
{
    [JsonProperty("id")] public string Id { get; set; } = null!;
    [JsonProperty("name")] public string Name { get; set; } = null!;
    [JsonProperty("status")] public OrganizationStatus? Status { get; set; }
}