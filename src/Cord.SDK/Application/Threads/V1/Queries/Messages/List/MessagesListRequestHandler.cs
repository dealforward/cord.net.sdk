using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.Messages.List;

internal sealed class MessagesListRequestHandler : IQueryHandler<MessagesListRequest, IEnumerable<MessageListItem>>
{
    private readonly IRestClient _restClient;

    public MessagesListRequestHandler(IRestClient restClient) => _restClient = restClient;

    public async Task<IEnumerable<MessageListItem>> Handle(MessagesListRequest request, CancellationToken cancellationToken)
    {
        var path = $"/v1/threads/{request.ThreadId}/messages";
        if (request.Direction is not null) path += $"?sortDirection={Enum.GetName(typeof(MessageListShortDirection), request.Direction)}";
        return (await _restClient.Get<IEnumerable<MessageListItem>>(path, cancellationToken)) ?? ArraySegment<MessageListItem>.Empty;
    }
}