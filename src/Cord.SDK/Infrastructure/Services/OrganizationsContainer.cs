namespace Cord.SDK.Infrastructure.Services;

[Obsolete("Please use the group API instead of this.")]
internal sealed class OrganizationsContainer : IOrganizationsContainer
{
    public OrganizationsContainer(IOrganizationsV1 v1)
    {
        V1 = v1;
    }

    public IOrganizationsV1 V1 { get; }
}