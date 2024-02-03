using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Queries.List;

internal sealed class GroupListRequestHandler : IQueryHandler<GroupListRequest, IEnumerable<GroupListItem>?>
{
    private readonly IRestClient _restClient;

    public GroupListRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<GroupListItem>?> Handle(GroupListRequest request, CancellationToken cancellationToken)
    {
        return await _restClient.Get<IEnumerable<GroupListItem>>("/v1/groups", cancellationToken);
    }
}