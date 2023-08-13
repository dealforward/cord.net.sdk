using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.Messages.Get;

internal sealed class MessagesGetRequestHandler : IQueryHandler<MessagesGetRequest, MessageGetItem?>
{
    private readonly IRestClient _restClient;

    public MessagesGetRequestHandler(IRestClient restClient) => _restClient = restClient;

    public async Task<MessageGetItem?> Handle(MessagesGetRequest request, CancellationToken cancellationToken)
    {
        return await _restClient.Get<MessageGetItem>($"/v1/threads/{request.ThreadId}/messages/{request.MessageId}", cancellationToken);
    }
}