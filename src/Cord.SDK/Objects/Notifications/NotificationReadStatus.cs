using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum NotificationReadStatus
{
    [EnumMember(Value = "unread")] Unread,
    [EnumMember(Value = "read")] Read,
}