using Cord.SDK.Application.Groups.V1.Commands.AddMembers;
using Cord.SDK.Application.Groups.V1.Commands.CreateOrUpdate;
using Cord.SDK.Application.Groups.V1.Commands.RemoveMember;
using Cord.SDK.Application.Groups.V1.Commands.UpdateMembers;
using Cord.SDK.Application.Groups.V1.Queries.Get;
using Cord.SDK.Application.Groups.V1.Queries.List;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class GroupsV1 : IGroupsV1
{
    private readonly IMediator _mediator;
    
    public GroupsV1(IMediator mediator) => _mediator = mediator;

    public async Task<CordResponse?>
        CreateOrUpdate(string id, GroupPutItem item, CancellationToken cancellationToken) =>
        await _mediator.Send(new GroupCreateOrUpdateRequest(id, item), cancellationToken);

    public async Task<IEnumerable<UserListItem>?> AddMembers(string id, IEnumerable<string> users,
        CancellationToken cancellationToken) =>
        await _mediator.Send(new GroupAddMemberRequest(id, users), cancellationToken);

    public async Task<IEnumerable<UserListItem>?> RemoveMembers(string id, IEnumerable<string> users,
        CancellationToken cancellationToken) =>
        await _mediator.Send(new GroupRemoveMemberRequest(id, users), cancellationToken);

    public async Task<IEnumerable<UserListItem>?> UpdateMembers(string id, GroupMemberPostItem item,
        CancellationToken cancellationToken) =>
        await _mediator.Send(new GroupUpdateMemberRequest(id, item), cancellationToken);

    public async Task<IEnumerable<GroupListItem>?> List(CancellationToken cancellationToken) =>
        await _mediator.Send(new GroupListRequest(), cancellationToken);

    public async Task<GroupGetItem?> Get(string id, CancellationToken cancellationToken) =>
        await _mediator.Send(new GroupGetRequest(id), cancellationToken);
}