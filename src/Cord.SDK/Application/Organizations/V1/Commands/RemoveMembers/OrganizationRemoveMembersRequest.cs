using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.RemoveMembers;

internal sealed record OrganizationRemoveMembersRequest
    (string Id, IEnumerable<string> Members) : ICommand<IEnumerable<UserListItem>?>;