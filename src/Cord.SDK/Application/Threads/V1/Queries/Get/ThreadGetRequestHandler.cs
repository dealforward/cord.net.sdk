using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.Get;

internal sealed class ThreadGetRequestHandler : IQueryHandler<ThreadGetRequest, ThreadGetItem?>
{
    private readonly IRestClient _restClient;

    public ThreadGetRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<ThreadGetItem?> Handle(ThreadGetRequest request, CancellationToken cancellationToken)
    {
        return await _restClient.Get<ThreadGetItem>($"/v1/threads/{request.Id}", cancellationToken);
    }
}