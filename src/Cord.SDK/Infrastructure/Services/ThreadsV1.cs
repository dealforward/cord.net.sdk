using Cord.SDK.Application.Threads.V1.Commands.Update;
using Cord.SDK.Application.Threads.V1.Queries.Get;
using Cord.SDK.Application.Threads.V1.Queries.List;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class ThreadsV1 : IThreadsV1
{
    private readonly IMediator _mediator;

    public ThreadsV1(IMediator mediator) => _mediator = mediator;


    public async Task<IEnumerable<ThreadListItem>> List(CancellationToken cancellationToken) =>
        await _mediator.Send(new ThreadListRequest(), cancellationToken);

    public async Task<ThreadGetItem?> Get(string id, CancellationToken cancellationToken) =>
        await _mediator.Send(new ThreadGetRequest(id), cancellationToken);

    public async Task<CordResponse?> Update(string id, ThreadPutItem item, CancellationToken cancellationToken) =>
        await _mediator.Send(new ThreadPutRequest(id, item), cancellationToken);
}