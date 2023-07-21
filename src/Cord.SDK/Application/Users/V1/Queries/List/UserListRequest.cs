using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Users.V1.Queries.List;

internal sealed record UserListRequest(UserListFilter? Filter) : IQuery<IEnumerable<UserListItem>>;