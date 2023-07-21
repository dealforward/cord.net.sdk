using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class ThreadGetItem
{
    [JsonProperty("id")] public string? Id { get;  set; }
    [JsonProperty("organizationID")] public string? OrganizationId { get;  set; }
    [JsonProperty("total")] public int Total { get;  set; }
    [JsonProperty("resolved")] public bool Resolved { get;  set; }
    [JsonProperty("resolvedTimestamp")] public DateTime? ResolvedTimestamp { get;  set; }
    [JsonProperty("participants")] public ThreadParticipants[]? Participants { get;  set; }
    [JsonProperty("typing")] public string[]? Typing { get;  set; }
    [JsonProperty("name")] public string? Name { get;  set; }
    [JsonProperty("url")] public string? Url { get;  set; }
    [JsonProperty("location")] public object? Location { get;  set; }
    [JsonProperty("metadata")] public object? Metadata { get;  set; }
}