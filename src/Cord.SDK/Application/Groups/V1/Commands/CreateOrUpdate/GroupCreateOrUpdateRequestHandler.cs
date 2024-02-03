using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.CreateOrUpdate;

internal sealed class GroupCreateOrUpdateRequestHandler : ICommandHandler<GroupCreateOrUpdateRequest, CordResponse?>
{
    private readonly IRestClient _restClient;

    public GroupCreateOrUpdateRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<CordResponse?> Handle(GroupCreateOrUpdateRequest request, CancellationToken cancellationToken)
    {
        return await _restClient.Put<CordResponse, GroupPutItem>($"/v1/groups/{request.Id}", request.Item,
            cancellationToken);
    }
}