using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.RemoveMember;

internal sealed record GroupRemoveMemberRequest(string Id, IEnumerable<string> Users)
    : ICommand<IEnumerable<UserListItem>?>;