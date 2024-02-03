using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.UpdateMembers;

internal sealed class
    GroupUpdateMemberRequestHandler : ICommandHandler<GroupUpdateMemberRequest, IEnumerable<UserListItem>?>
{
    private readonly IRestClient _restClient;

    public GroupUpdateMemberRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<UserListItem>?> Handle(GroupUpdateMemberRequest request,
        CancellationToken cancellationToken)
    {
        return await _restClient.Post<IEnumerable<UserListItem>, GroupMemberPostItem>(
            $"/v1/groups/{request.Id}/members", request.Item, cancellationToken);
    }
}