using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.UpdateMembers;

[Obsolete("Please use the group API instead of this.")]
internal sealed class
    OrganizationUpdateMembersRequestHandler : ICommandHandler<OrganizationUpdateMembersRequest,
        IEnumerable<UserListItem>?>
{
    private readonly IRestClient _restClient;

    public OrganizationUpdateMembersRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<UserListItem>?> Handle(OrganizationUpdateMembersRequest request,
        CancellationToken cancellationToken)
    {
        return await _restClient.Post<IEnumerable<UserListItem>, OrganizationUpdateMembers>(
            $"v1/organizations/{request.Id}/members", request.Members,
            cancellationToken);
    }
}