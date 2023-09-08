using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cord.SDK.Objects;

public sealed class MentionContent : MessageContent
{
    public sealed class UserIdentifier
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonConstructor]
        public UserIdentifier(string id)
        {
            Id = id;
        }
    }

    public MentionContent()
    {
    }

    public MentionContent(string userId)
    {
        this.User = new UserIdentifier(userId);
    }

    [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))] public MessageContentType Type { get; set; } = MessageContentType.Mention;
    [JsonProperty("children")] public List<MessageContent> Children { get; set; } = new();
    [JsonProperty("user")] public UserIdentifier? User { get; set; }
}
