using Cord.SDK.Application.Threads.V1.Commands.Message.Delete;
using Cord.SDK.Application.Threads.V1.Commands.Message.Post;
using Cord.SDK.Application.Threads.V1.Queries.Messages.Get;
using Cord.SDK.Application.Threads.V1.Queries.Messages.List;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class MessagesV1 : IMessagesV1
{
    private readonly IMediator _mediator;

    public MessagesV1(IMediator mediator) => _mediator = mediator;

    public async Task<CordResponse> Delete(string threadId, string messageId, CancellationToken cancellationToken) => await _mediator.Send(new MessageDeleteRequest(threadId, messageId), cancellationToken);

    public async Task<MessageListItem?> Get(string threadId, string messageId, CancellationToken cancellationToken) => await _mediator.Send(new MessagesGetRequest(threadId, messageId), cancellationToken);

    public async Task<IEnumerable<MessageListItem>> List(string threadId, MessageListShortDirection? direction, CancellationToken cancellationToken) => await _mediator.Send(new MessagesListRequest(threadId, direction), cancellationToken);

    public async Task<CordResponse> Post(string threadId, MessagePostItem item, CancellationToken cancellationToken) => await _mediator.Send(new MessagePostRequest(threadId, item), cancellationToken);
}
