using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cord.SDK.Objects;

public sealed class MessagePostItem
{
    public MessagePostItem(string authorId)
    {
        Id = $"SDK:{Guid.NewGuid():N}";
        AuthorId = authorId;
    }

    public MessagePostItem(string id, string authorId)
    {
        Id = id;
        AuthorId = authorId;
    }

    /// <summary>
    /// The ID for the message.
    /// </summary>
    [JsonProperty("id")] public string Id { get; set; }
    /// <summary>
    /// The ID for the user that sent the message.
    /// </summary>
    [JsonProperty("authorID")] public string AuthorId { get; set; }
    /// <summary>
    /// The content of the message.
    /// </summary>
    [JsonProperty("content")] public List<MessageContent> Content { get; set; } = new();
    /// <summary>
    /// The URL of the icon to show next to the message. 
    /// This is only used for action_message messages; other messages show the avatar of the author. 
    /// If an action_message does not have an icon set, no icon is shown. uri
    /// </summary>
    [JsonProperty("iconURL")] public string? IconUrl { get; set; }
    /// <summary>
    /// Arbitrary key-value pairs that can be used to store additional information.
    /// </summary>
    [JsonProperty("metadata")] public object? Metadata { get; set; }
    /// <summary>
    /// A URL where the message can be seen. 
    /// This determines where a user is sent when they click on a reference to this message, such as in a notification. 
    /// If unset, it defaults to the thread's URL.
    /// </summary>
    [JsonProperty("url")] public string? Url { get; set; }
    /// <summary>
    /// The type of message this is. A user_message is a message that the author sent. 
    /// An action_message is a message about something that happened, such as the thread being resolved. 
    /// The default value is user_message.
    /// </summary>
    [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))] public MessageType Type { get; set; } = MessageType.UserMessage;
    /// <summary>
    /// A optional space separated list of classnames to add to the message.
    /// </summary>
    [JsonProperty("extraClassnames")] public string? ExtraClassnames { get; set; }

    public MessagePostItem AddText(string messageText)
    {
        var message = new PackageContent();
        message.Children.Add(new TextContent(messageText));
        Content.Add(message);
        return this;
    }
    public MessagePostItem AddMention(string userId, string mentionText)
    {
        var message = new PackageContent();
        mentionText = mentionText.First() is '@' ? mentionText : $"@{mentionText}";
        var mention = new MentionContent
        {
            User = new MentionContent.UserIdentifier(userId)
        };
        mention.Children.Add(new TextContent(mentionText));
        message.Children.Add(mention);
        Content.Add(message);
        return this;
    }

    public PackageContent CreatePackage()
    {
        var package = new PackageContent();
        Content.Add(package);
        return package;
    }

}