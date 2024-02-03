using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.CreateOrUpdate;

[Obsolete("Please use the group API instead of this.")]
internal sealed class
    OrganizationCreateOrUpdateRequestHandler : ICommandHandler<OrganizationCreateOrUpdateRequest, CordResponse?>
{
    private readonly IRestClient _restClient;

    public OrganizationCreateOrUpdateRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<CordResponse?> Handle(OrganizationCreateOrUpdateRequest request,
        CancellationToken cancellationToken)
    {
        return await _restClient.Put<CordResponse, OrganizationPutItem>($"/v1/organizations/{request.Id}", request.Item,
            cancellationToken);
    }
}