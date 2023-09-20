using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum MessageListShortDirection
{
    [EnumMember(Value = "ascending")] Ascending,
    [EnumMember(Value = "descending")] Descending
}