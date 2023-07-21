using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Users.V1.Commands.CreateOrUpdate;

internal sealed class UserCreateOrUpdateRequestHandler : ICommandHandler<UserCreateOrUpdateRequest, CordResponse?>
{
    private readonly IRestClient _restClient;

    public UserCreateOrUpdateRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<CordResponse?> Handle(UserCreateOrUpdateRequest request, CancellationToken cancellationToken)
    {
        var item = Newtonsoft.Json.JsonConvert.SerializeObject(request.Item);
        return await _restClient.Put<CordResponse, UserPutItem>($"/v1/users/{request.Id}", request.Item,
            cancellationToken);
    }
}