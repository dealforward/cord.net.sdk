using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Users.V1.Queries.List;

internal sealed class UserListRequestHandler : IQueryHandler<UserListRequest, IEnumerable<UserListItem>>
{
    private readonly IRestClient _restClient;

    public UserListRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<IEnumerable<UserListItem>> Handle(UserListRequest request, CancellationToken cancellationToken)
    {
        var filter = request.Filter.ToJsonIgnoreNulls();
        var query = new List<(string key, string value, bool? encode)>();
        if (filter is not null) query.Add(("filter", filter, true));
        return await _restClient.Get<IEnumerable<UserListItem>>("/v1/users", query, cancellationToken) ??
               ArraySegment<UserListItem>.Empty;
    }
}