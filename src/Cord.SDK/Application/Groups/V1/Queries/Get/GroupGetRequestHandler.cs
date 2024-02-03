using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Queries.Get;

internal sealed class GroupGetRequestHandler : IQueryHandler<GroupGetRequest, GroupGetItem?>
{
    private readonly IRestClient _restClient;

    public GroupGetRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<GroupGetItem?> Handle(GroupGetRequest request, CancellationToken cancellationToken)
    {
        return await _restClient.Get<GroupGetItem>($"/v1/groups/{request.Id}", cancellationToken);
    }
}