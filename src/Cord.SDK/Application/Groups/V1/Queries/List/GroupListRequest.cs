using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Queries.List;

internal sealed record GroupListRequest : IQuery<IEnumerable<GroupListItem>?>;