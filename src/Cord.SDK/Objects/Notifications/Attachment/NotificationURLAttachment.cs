using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class NotificationURLAttachment : NotificationAttachment
{
    public NotificationURLAttachment()
    {
        Type = NotificationAttachmentType.Url;
    }
    public NotificationURLAttachment(string url)
    {
        Url = url;
    }
    /// <summary>
    /// The URL this attachment points to. 
    /// This would typically be the URL to send the browser to if this notification is clicked.
    /// </summary>
    [JsonProperty("url")] public string Url { get; set; } = string.Empty;
}
