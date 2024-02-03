using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.UpdateMembers;

internal sealed record GroupUpdateMemberRequest(string Id, GroupMemberPostItem Item)
    : ICommand<IEnumerable<UserListItem>?>;