using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.AddMembers;

[Obsolete("Please use the group API instead of this.")]
internal sealed record OrganizationAddMembersRequest
    (string Id, IEnumerable<string> Members) : ICommand<IEnumerable<UserListItem>>;