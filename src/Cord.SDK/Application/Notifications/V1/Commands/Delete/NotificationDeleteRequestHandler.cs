using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Notifications.V1.Commands.Delete;

internal sealed class NotificationDeleteRequestHandler : ICommandHandler<NotificationDeleteRequest, CordResponse>
{
    private readonly IRestClient _restClient;

    public NotificationDeleteRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<CordResponse> Handle(NotificationDeleteRequest request, CancellationToken cancellationToken)
    {
        return (await _restClient.Delete<CordResponse>($"/v1/notifications/{request.Id}", cancellationToken))!;
    }
}