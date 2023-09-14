using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class NotificationMessageAttachment : NotificationAttachment
{
    public enum CoreMessageDataType
    {
        [EnumMember(Value = "action_message")] ActionMessage,
        [EnumMember(Value = "user_message")] UserMessage
    }
    /// <summary>
    /// The relevant message.
    /// </summary>
    public sealed class CoreMessageData
    {
        /// <summary>
        /// The ID for the message. 
        /// If a message is created with no ID, a random UUID-based ID will be automatically created for it.
        /// </summary>
        [JsonProperty("id")] public string Id { get; set; } = null!;
        /// <summary>
        /// The ID for the user that sent the message.
        /// </summary>
        [JsonProperty("authorID")] public string AuthorId { get; set; } = null!;
        /// <summary>
        /// The ID for the organization this message belongs to.
        /// </summary>
        [JsonProperty("organizationID")] public string OrganizationId { get; set; } = null!;
        /// <summary>
        /// The ID for the thread this message is part of.
        /// </summary>
        [JsonProperty("threadID")] public string ThreadID { get; set; } = null!;
        /// <summary>
        /// The content of the message.
        /// </summary>
        [JsonProperty("content")] public IEnumerable<MessageContent>? Contents { get; set; }
        /// <summary>
        /// A plaintext version of the structured message content.
        /// </summary>
        [JsonProperty("plaintext")] public string Plaintext { get; set; } = null!;
        /// <summary>
        /// A URL where the message can be seen. 
        /// This determines where a user is sent when they click on a reference to this message, such as in a notification.
        /// If unset, it defaults to the thread's URL.
        /// </summary>
        [JsonProperty("url")] public string? Url { get; set; }
        /// <summary>
        /// The timestamp when this message was created. The default value is the current time.
        /// </summary>
        [JsonProperty] public DateTime CreatedTimestamp { get; set; }
        /// <summary>
        /// The timestamp when this message was deleted, if it was. If unset, the message is not deleted.
        /// </summary>
        [JsonProperty("deletedTimestamp")] public DateTime? DeletedTimestamp { get; set; }
        /// <summary>
        /// The timestamp when this message was last edited, if it ever was. If unset, the message does not show as edited.
        /// </summary>
        [JsonProperty("updatedTimestamp")] public DateTime? UpdatedTimestamp { get; set; }
        /// <summary>
        /// The URL of the icon to show next to the message. 
        /// This is only used for action_message messages; other messages show the avatar of the author. 
        /// If an action_message does not have an icon set, no icon is shown.
        /// </summary>
        [JsonProperty("iconURL")] public string? IconURL { get; set; }
        /// <summary>
        /// The type of message this is. 
        /// A UserMessage is a message that the author sent. 
        /// An ActionMessage is a message about something that happened, such as the thread being resolved. 
        /// The default value is UserMessage.
        /// </summary>
        [JsonProperty("type")] public CoreMessageDataType Type { get; set; } = CoreMessageDataType.UserMessage;
        /// <summary>
        /// Arbitrary key-value pairs that can be used to store additional information.
        /// </summary>
        [JsonProperty("metadata")] public object? Metadata { get; set; }
        /// <summary>
        /// A optional space separated list of classnames to add to the message.
        /// </summary>
        [JsonProperty("extraClassnames")] public string? ExtraClassnames { get; set; }
        /// <summary>
        /// The items attached to this message.
        /// </summary>
        [JsonProperty("attachments")] public IEnumerable<IAttachment>? Attachments { get; set; }
        /// <summary>
        /// The reactions to this message.
        /// </summary>
        [JsonProperty("reactions")] public IEnumerable<MessageReaction>? Reactions { get; set; }
        /// <summary>
        /// A list of IDs of the users that have seen the message.
        /// </summary>
        [JsonProperty("seenBy")] public IEnumerable<string>? SeenBy { get; set; }
    }

    public NotificationMessageAttachment()
    {
        Type = NotificationAttachmentType.Message;
    }

    public NotificationMessageAttachment(CoreMessageData message)
    {
        Message = message;
        Type = NotificationAttachmentType.Message;
    }

    /// <summary>
    /// The relevant message.
    /// </summary>
    [JsonProperty("message")] public CoreMessageData? Message { get; set; }
}
