using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.AddMembers;

internal sealed record OrganizationAddMembersRequest
    (string Id, IEnumerable<string> Members) : ICommand<IEnumerable<UserListItem>>;