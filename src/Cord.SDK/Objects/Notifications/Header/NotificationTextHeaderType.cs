using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum NotificationTextHeaderType
{
    [EnumMember(Value = "text")] Text,
    [EnumMember(Value = "user")] User
}
