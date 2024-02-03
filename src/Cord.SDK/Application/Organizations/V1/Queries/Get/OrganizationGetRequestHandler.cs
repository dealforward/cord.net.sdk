using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Queries.Get;

[Obsolete("Please use the group API instead of this.")]
internal sealed class OrganizationGetRequestHandler : IQueryHandler<OrganizationGetRequest, OrganizationGetItem?>
{
    private readonly IRestClient _restClient;

    public OrganizationGetRequestHandler(IRestClient restClient) => _restClient = restClient;

    public async Task<OrganizationGetItem?> Handle(OrganizationGetRequest request,
        CancellationToken cancellationToken)
    {
        return await _restClient.Get<OrganizationGetItem>($"/v1/organizations/{request.Id}", cancellationToken);
    }
}