using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class OrganizationListItem
{
    [JsonProperty("id")] public string Id { get; set; } = null!;
    [JsonProperty("name")] public string Name { get; set; } = null!;
    [JsonProperty("status")] public OrganizationStatus? Status { get; set; }
}