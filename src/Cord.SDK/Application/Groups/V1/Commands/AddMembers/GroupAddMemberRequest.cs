using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.AddMembers;

internal sealed record GroupAddMemberRequest(string Id, IEnumerable<string> Users)
    : ICommand<IEnumerable<UserListItem>?>;