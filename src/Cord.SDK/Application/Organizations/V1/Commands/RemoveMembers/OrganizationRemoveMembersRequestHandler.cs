using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.RemoveMembers;

internal sealed class
    OrganizationRemoveMembersRequestHandler : ICommandHandler<OrganizationRemoveMembersRequest,
        IEnumerable<UserListItem>?>
{
    private readonly IRestClient _restClient;

    public OrganizationRemoveMembersRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<UserListItem>?> Handle(OrganizationRemoveMembersRequest request,
        CancellationToken cancellationToken)
    {
        return await _restClient.Post<IEnumerable<UserListItem>, OrganizationUpdateMembers>(
            $"v1/organizations/{request.Id}/members",
            new OrganizationUpdateMembers(ArraySegment<string>.Empty, request.Members),
            cancellationToken);
    }
}