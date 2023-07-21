using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.UpdateMembers;

internal sealed record OrganizationUpdateMembersRequest
    (string Id, OrganizationUpdateMembers Members) : ICommand<IEnumerable<UserListItem>>;