using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Notifications.V1.Commands.Create;

internal sealed class NotificationPostRequestHandler : ICommandHandler<NotificationPostRequest, CordResponse>
{
    private readonly IRestClient _restClient;

    public NotificationPostRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }

    public async Task<CordResponse> Handle(NotificationPostRequest request, CancellationToken cancellationToken)
    {
        return (await _restClient.Post<CordResponse, NotificationPostItem>("/v1/notifications", request.Item, cancellationToken))!;
    }
}