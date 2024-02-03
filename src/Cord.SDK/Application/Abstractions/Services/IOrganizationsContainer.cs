namespace Cord.SDK;

[Obsolete("Please use the group API instead of this.")]
public interface IOrganizationsContainer
{
    /// <summary>
    /// REST API of version 1
    /// </summary>
    /// <value></value>
    IOrganizationsV1 V1 { get; }
}