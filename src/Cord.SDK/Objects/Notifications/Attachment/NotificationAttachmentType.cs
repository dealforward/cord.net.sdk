using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum NotificationAttachmentType
{
    [EnumMember(Value = "url")] Url,
    [EnumMember(Value = "message")] Message
}
