using Cord.SDK.Application.Threads.V1.Queries.Messages.List;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class MessagesV1 : IMessagesV1
{
    private readonly IMediator _mediator;

    public MessagesV1(IMediator mediator) => _mediator = mediator;

    public async Task<IEnumerable<MessageListItem>> List(string threadId, MessageListShortDirection? direction, CancellationToken cancellationToken) => await _mediator.Send(new MessagesListRequest(threadId, direction), cancellationToken);
}
