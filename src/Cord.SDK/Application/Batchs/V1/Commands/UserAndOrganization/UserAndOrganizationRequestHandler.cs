using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Batchs.V1.Commands.UserAndOrganization;

internal sealed class UserAndOrganizationRequestHandler : ICommandHandler<UserAndOrganizationRequest, CordResponse>
{
    private readonly IRestClient _restClient;
    public UserAndOrganizationRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }
    public async Task<CordResponse> Handle(UserAndOrganizationRequest request, CancellationToken cancellationToken)
    {
        return (await _restClient.Post<CordResponse, BatchUserAndOrganizationItem>("/v1/batch", request.Item, cancellationToken))!;
    }
}