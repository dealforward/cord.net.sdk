using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cord.SDK.Objects;

public sealed class GroupGetItem
{
    [JsonProperty("id")] public string Id { get; set; } = null!;
    [JsonProperty("name")] public string Name { get; set; } = null!;
    [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))] public GroupStatus Status { get; set; }
    [JsonProperty("members")] public IEnumerable<string> Members { get; set; } = null!;
    [JsonProperty("connectedToSlack")] public bool ConnectedToSlack { get; set; }
    [JsonProperty("metadata")] public object? Metadata { get; set; }
}