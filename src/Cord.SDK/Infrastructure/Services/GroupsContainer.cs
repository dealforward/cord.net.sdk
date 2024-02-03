namespace Cord.SDK.Infrastructure.Services;

internal sealed class GroupsContainer : IGroupsContainer
{
    public GroupsContainer(IGroupsV1 v1)
    {
        V1 = v1;
    }
    public IGroupsV1 V1 { get; }
}