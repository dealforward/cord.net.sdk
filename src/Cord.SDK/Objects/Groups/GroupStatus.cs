using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum GroupStatus
{
    [EnumMember(Value = "active")] Active,
    [EnumMember(Value = "deleted")] Deleted
}