using Newtonsoft.Json;

namespace Cord.SDK.Objects;
public sealed class NotificationListItem
{
    /// <summary>
    /// The ID for this notification.
    /// </summary>
    [JsonProperty("id")] public string Id { get; set; } = null!;
    /// <summary>
    /// The IDs of the user(s) who sent this notification. 
    /// The Cord backend will sometimes aggregate multiple notifications together, causing them to have multiple senders. 
    /// For example, if multiple people react to the same message, 
    /// that will generate only one notification (but with multiple senders, one for each person who reacted).
    /// </summary>
    [JsonProperty("senderUserIDs")] public IEnumerable<string> SenderUserIds { get; set; } = null!;
    /// <summary>
    /// The URL of an icon image for this notification, if one was specified when it was created. 
    /// This will always be null for Cord's internally-generated notifications 
    /// (i.e., it can only be non-null for notifications you create via the REST API).
    /// </summary>
    [JsonProperty("iconUrl")] public string? IconUrl { get; set; }
    /// <summary>
    /// The "header" or "text" of the notification. 
    /// This will represent text like "Alice replied to your thread." or similar. 
    /// For notifications you create via the REST API, this will be based upon the template parameter, see below.
    /// </summary>
    [JsonProperty("header")] public IEnumerable<NotificationHeader> Header { get; set; } = null!;
    /// <summary>
    /// Additional context attached to the notification. 
    /// For example, if this notification is about a new reaction on a message, the attachment will specify what message received that new reaction.
    /// A renderer will typically check the type field of the attachment and render that attachment type below the header.
    /// </summary>
    [JsonProperty("attachment")] public NotificationAttachment? Attachment { get; set; }
    /// <summary>
    /// Whether this notification has been read by the recipient yet.
    /// </summary>
    [JsonProperty("readStatus")] public NotificationReadStatus ReadStatus { get; set; }
    /// <summary>
    /// The time this notification was sent.
    /// </summary>
    [JsonProperty("timestamp")] public DateTime Timestamp { get; set; }
    /// <summary>
    /// A space separated list of classnames to add to the notification.
    /// </summary>
    [JsonProperty("extraClassnames")] public string? ExtraClassnames { get; set; }
    /// <summary>
    /// An arbitrary JSON object specified when the notification was created. 
    /// This will always be an empty object for Cord's internally-generated notifications 
    /// 0(i.e., it can only be non-null for notifications you create via the REST API).
    /// </summary>
    [JsonProperty("metadata")] public object? Metadata { get; set; }
}
