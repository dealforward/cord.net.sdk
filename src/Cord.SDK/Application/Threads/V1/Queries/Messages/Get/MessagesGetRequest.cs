using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.Messages.Get;
internal sealed record MessagesGetRequest(string ThreadId, string MessageId) : IQuery<MessageGetItem?>;
