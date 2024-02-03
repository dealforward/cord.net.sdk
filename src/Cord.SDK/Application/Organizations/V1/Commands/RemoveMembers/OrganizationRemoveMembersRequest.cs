using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.RemoveMembers;

[Obsolete("Please use the group API instead of this.")]
internal sealed record OrganizationRemoveMembersRequest
    (string Id, IEnumerable<string> Members) : ICommand<IEnumerable<UserListItem>?>;