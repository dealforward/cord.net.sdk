using Cord.SDK.Objects.Notifications.Converters;
using Newtonsoft.Json;

namespace Cord.SDK.Objects;

[JsonConverter(typeof(NotificationAttachmentConverter))]
public abstract class NotificationAttachment
{
    [JsonProperty("type")] public NotificationAttachmentType Type { get; set; }
}
