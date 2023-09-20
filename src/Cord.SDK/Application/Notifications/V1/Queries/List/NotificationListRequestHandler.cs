using Cord.SDK.Application.Abstractions.HttpRequest;
using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Notifications.V1.Queries.List;

internal sealed class NotificationListRequestHandler : IQueryHandler<NotificationListRequest, IEnumerable<NotificationListItem>>
{
    private readonly IRestClient _restClient;

    public NotificationListRequestHandler(IRestClient restClient)
    {
        _restClient = restClient;
    }
    

    public async Task<IEnumerable<NotificationListItem>> Handle(NotificationListRequest request, CancellationToken cancellationToken)
    {
         return (await _restClient.Get<IEnumerable<NotificationListItem>>($"/v1/users/{request.UserId}/notifications", cancellationToken)) ??
               ArraySegment<NotificationListItem>.Empty;
    }
}