using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cord.SDK.Objects;

public sealed class PackageContent : MessageContent
{
    [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))] public MessageContentType Type { get; set; } = MessageContentType.Package;
    [JsonProperty("children")] public List<MessageContent> Children { get; set; } = new();

    public PackageContent AddText(string messageText)
    {
        Children.Add(new TextContent(messageText));
        return this;
    }
    public PackageContent AddMention(string userId, string mentionText)
    {
        mentionText = mentionText.First() is '@' ? mentionText : $"@{mentionText}";
        var mention = new MentionContent
        {
            User = new MentionContent.UserIdentifier(userId)
        };
        mention.Children.Add(new TextContent(mentionText));
        mention.Children.Add(mention);
        Children.Add(mention);
        return this;
    }
}
