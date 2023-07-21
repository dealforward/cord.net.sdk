using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IOrganizationsV1
{
    Task<CordResponse?> CreateOrUpdate(string id, OrganizationPutItem item, CancellationToken cancellationToken);

    Task<IEnumerable<UserListItem>?> UpdateMembers(string id, OrganizationUpdateMembers members,
        CancellationToken cancellationToken);

    Task<IEnumerable<UserListItem>?> AddMembers(string id, IEnumerable<string> members,
        CancellationToken cancellationToken);

    Task<IEnumerable<UserListItem>?> RemoveMembers(string id, IEnumerable<string> members,
        CancellationToken cancellationToken);

    Task<IEnumerable<OrganizationListItem>?> List(CancellationToken cancellationToken);
    Task<OrganizationGetItem?> Get(string id, CancellationToken cancellationToken);
}