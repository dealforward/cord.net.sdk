using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.AddMembers;

internal sealed class GroupAddMemberRequestHandler : ICommandHandler<GroupAddMemberRequest, IEnumerable<UserListItem>?>
{
    private readonly IRestClient _restClient;

    public GroupAddMemberRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<UserListItem>?> Handle(GroupAddMemberRequest request,
        CancellationToken cancellationToken)
    {
        var item = new GroupMemberPostItem(add: request.Users);
        return await _restClient.Post<IEnumerable<UserListItem>?, GroupMemberPostItem>(
            $"/v1/groups/{request.Id}/members", item, cancellationToken);
    }
}