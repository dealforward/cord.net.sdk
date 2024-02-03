using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.AddMembers;

[Obsolete("Please use the group API instead of this.")]
internal sealed class
    OrganizationAddMembersRequestHandler : ICommandHandler<OrganizationAddMembersRequest, IEnumerable<UserListItem>?>
{
    private readonly IRestClient _restClient;

    public OrganizationAddMembersRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<UserListItem>?> Handle(OrganizationAddMembersRequest request,
        CancellationToken cancellationToken)
    {
        return await _restClient.Post<IEnumerable<UserListItem>, OrganizationUpdateMembers>(
            $"v1/organizations/{request.Id}/members",
            new OrganizationUpdateMembers(request.Members, ArraySegment<string>.Empty),
            cancellationToken);
    }
}