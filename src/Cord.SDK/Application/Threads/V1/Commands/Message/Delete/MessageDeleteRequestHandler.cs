using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Commands.Message.Delete;

internal sealed class MessageDeleteRequestHandler : ICommandHandler<MessageDeleteRequest, CordResponse>
{
    private readonly IRestClient _restClient;

    public MessageDeleteRequestHandler(IRestClient restClient) => _restClient = restClient;

    public async Task<CordResponse> Handle(MessageDeleteRequest request, CancellationToken cancellationToken)
    {
        return (await _restClient.Delete<CordResponse>($"/v1/threads/{request.ThreadId}/messages/{request.MessageId}", cancellationToken))!;
    }
}
