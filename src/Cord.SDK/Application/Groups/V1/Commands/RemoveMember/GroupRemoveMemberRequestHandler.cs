using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.RemoveMember;

internal sealed class
    GroupRemoveMemberRequestHandler : ICommandHandler<GroupRemoveMemberRequest, IEnumerable<UserListItem>?>
{
    private readonly IRestClient _restClient;

    public GroupRemoveMemberRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }


    public async Task<IEnumerable<UserListItem>?> Handle(GroupRemoveMemberRequest request,
        CancellationToken cancellationToken)
    {
        var item = new GroupMemberPostItem(remove: request.Users);
        return await _restClient.Post<IEnumerable<UserListItem>, GroupMemberPostItem>(
            $"/v1/groups/{request.Id}/members", item, cancellationToken);
    }
}