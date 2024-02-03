using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.Delete;

internal sealed class GroupDeleteRequestHandler : ICommandHandler<GroupDeleteRequest, CordResponse?>
{
    private readonly IRestClient _restClient;

    public GroupDeleteRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }


    public async Task<CordResponse?> Handle(GroupDeleteRequest request, CancellationToken cancellationToken)
    {
        return await _restClient.Delete<CordResponse?>($"/v1/groups/{request.Id}", cancellationToken);
    }
}