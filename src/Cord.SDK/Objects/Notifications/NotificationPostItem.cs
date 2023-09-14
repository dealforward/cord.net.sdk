using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class NotificationPostItem
{
    /// <summary>
    /// ID of user who is the "actor" sending the notification, i.e., the user taking the action the notification is about.
    /// Required if template includes {{actor}}.
    /// </summary>
    [JsonProperty("actorID")] public string? ActorId { get; set; }
    /// <summary>
    /// ID of user receiving the notification.
    /// </summary>
    [JsonProperty("recipientID")] public string RecipientId { get; set; }
    /// <summary>
    /// Template for the header of the notification. The expressions {{actor}} and {{recipient}} will be replaced respectively with the notification's actor and recipient.
    /// </summary>
    [JsonProperty("template")] public string Template { get; set; }
    /// <summary>
    /// URL of page to go to when the notification is clicked.
    /// </summary>
    [JsonProperty("url")] public string Url { get; set; }
    /// <summary>
    /// URL of an icon image if a specific one is desired. 
    /// For notifications with an actor_id this will default to the sender's profile picture, otherwise it will default to a bell icon.
    /// </summary>
    [JsonProperty("iconUrl")] public string? IconUrl { get; set; }
    /// <summary>
    /// Currently must be set to url. In the future this may specify different types of notifications, but for now only url is defined.
    /// </summary>
    [JsonProperty("type")] public string Type => "url";
    /// <summary>
    /// An arbitrary JSON object that can be used to set additional metadata on the notification.
    /// </summary>
    [JsonProperty("metadata")] public object? Metadata { get; set; }
    /// <summary>
    /// An optional space separated list of classnames to add to the notification.
    /// </summary>
    [JsonProperty("extraClassnames")] public string? ExtraClassnames { get; set; }

    /// <summary>
    /// Create a post Item
    /// </summary>
    /// <param name="recipientId">ID of user receiving the notification.</param>
    /// <param name="template">Template for the header of the notification. The expressions {{actor}} and {{recipient}} will be replaced respectively with the notification's actor and recipient.</param>
    /// <param name="url">Currently must be set to url. In the future this may specify different types of notifications, but for now only url is defined.</param>
    public NotificationPostItem(string recipientId, string template, string url)
    {
        RecipientId = recipientId;
        Template = template;
        Url = url;
    }
}
