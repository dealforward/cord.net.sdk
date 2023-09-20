using Cord.SDK.Objects.Notifications.Converters;
using Newtonsoft.Json;

namespace Cord.SDK.Objects;

[JsonConverter(typeof(NotificationHeaderConverter))]
public abstract class NotificationHeader
{
    /// <summary>
    /// Indicator that this is a string header node.
    /// </summary>
    [JsonProperty("type")] public NotificationTextHeaderType Type { get; set; }
}
