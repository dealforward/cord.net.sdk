using System.Runtime.Serialization;

namespace Cord.SDK.Objects;
/// <summary>
/// Represents the status of the organization
/// </summary>
[Obsolete("Please use the group API instead of this.")]
public enum OrganizationStatus
{
    [EnumMember(Value = "active")] Active,
    [EnumMember(Value = "deleted")] Deleted
}