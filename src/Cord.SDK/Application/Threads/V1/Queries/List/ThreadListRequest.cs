using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.List;

internal sealed record ThreadListRequest : IQuery<IEnumerable<ThreadListItem>>;