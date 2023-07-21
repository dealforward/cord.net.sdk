using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.List;

internal sealed class ThreadListRequestHandler : IQueryHandler<ThreadListRequest, IEnumerable<ThreadListItem>>
{
    private readonly IRestClient _restClient;

    public ThreadListRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<ThreadListItem>> Handle(ThreadListRequest request,
        CancellationToken cancellationToken)
    {
        return (await _restClient.Get<IEnumerable<ThreadListItem>>("/v1/threads/", cancellationToken)) ??
               ArraySegment<ThreadListItem>.Empty;
    }
}