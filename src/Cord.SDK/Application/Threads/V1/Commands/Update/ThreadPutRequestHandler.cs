using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Commands.Update;

internal sealed class ThreadPutRequestHandler : ICommandHandler<ThreadPutRequest, CordResponse?>
{
    private readonly IRestClient _restClient;

    public ThreadPutRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<CordResponse?> Handle(ThreadPutRequest request, CancellationToken cancellationToken)
    {
        return await _restClient.Put<CordResponse, ThreadPutItem>($"/v1/threads/{request.Id}", request.Item, cancellationToken);
    }
}