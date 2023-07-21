using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Queries.List;

internal sealed class
    OrganizationListRequestHandler : IQueryHandler<OrganizationListRequest, IEnumerable<OrganizationListItem>?>
{
    private readonly IRestClient _restClient;

    public OrganizationListRequestHandler(IRestClient restClient) => _restClient = restClient;


    public async Task<IEnumerable<OrganizationListItem>?> Handle(OrganizationListRequest request,
        CancellationToken cancellationToken)
    {
        return await _restClient.Get<IEnumerable<OrganizationListItem>>("v1/organizations", cancellationToken);
    }
}