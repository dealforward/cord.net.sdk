using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cord.SDK.Objects;
/// <summary>
/// Used to update organization data.
/// </summary>
public sealed class OrganizationPutItem
{
    [JsonConstructor]
    public OrganizationPutItem(string name) => Name = name;

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))]
    public OrganizationStatus Status { get; set; } = OrganizationStatus.Active;

    [JsonProperty("members")] public List<string> Members { get; set; } = new();
    /// <summary>
    /// Add a new member.
    /// </summary>
    /// <param name="memberId"></param>
    /// <returns></returns>
    public OrganizationPutItem AddMember(string memberId)
    {
        Members?.Add(memberId);
        return this;
    }
}

public sealed record OrganizationUpdateMembers(IEnumerable<string> Add, IEnumerable<string> Remove);