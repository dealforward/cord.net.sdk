using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cord.SDK.Objects;

public sealed class GroupPutItem
{
    public GroupPutItem
    (
        string name
    )
    {
        Name = name;
    }

    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))] public GroupStatus Status { get; set; } = GroupStatus.Active;
    [JsonProperty("metadata")] public object? Metadata { get; set; }
    [JsonProperty("members")] public ICollection<string>? Members { get; set; }

    public GroupPutItem AddMember(string id)
    {
        Members ??= new List<string>();
        Members.Add(id);
        return this;
    }
}