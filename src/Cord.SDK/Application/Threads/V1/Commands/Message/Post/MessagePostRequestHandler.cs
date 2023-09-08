using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Commands.Message.Post;

internal sealed class MessagePostRequestHandler : ICommandHandler<MessagePostRequest, CordResponse>
{
    private readonly IRestClient _restClient;

    public MessagePostRequestHandler(IRestClient restClient) => _restClient = restClient;
    public async Task<CordResponse> Handle(MessagePostRequest request, CancellationToken cancellationToken)
    {
        return (await _restClient.Post<CordResponse, MessagePostItem>($"/v1/threads/{request.ThreadId}/messages", request.Item, cancellationToken))!;
    }
}