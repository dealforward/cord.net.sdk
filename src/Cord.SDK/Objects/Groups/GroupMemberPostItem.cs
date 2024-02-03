using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class GroupMemberPostItem
{
    public GroupMemberPostItem
    (
        IEnumerable<string>? add = null,
        IEnumerable<string>? remove = null
    )
    {
        Add = add ?? ArraySegment<string>.Empty;
        Remove = remove ?? ArraySegment<string>.Empty;
    }

    [JsonProperty("add")] public IEnumerable<string> Add { get; private set; }
    [JsonProperty("remove")] public IEnumerable<string> Remove { get; private set; }
}