using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.Messages.List;
internal sealed record MessagesListRequest(string ThreadId, MessageListShortDirection? Direction) : IQuery<IEnumerable<MessageListItem>>;
