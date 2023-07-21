using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Users.V1.Queries.Get;

internal sealed class UserGetRequestHandler : IQueryHandler<UserGetRequest, UserGetItem?>
{
    private readonly IRestClient _restClient;

    public UserGetRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<UserGetItem?> Handle(UserGetRequest? request, CancellationToken cancellationToken)
    {
        return await _restClient.Get<UserGetItem>("/v1/users/", cancellationToken);
    }
}