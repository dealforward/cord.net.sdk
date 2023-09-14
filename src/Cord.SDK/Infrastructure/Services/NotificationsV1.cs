using Cord.SDK.Application.Notifications.V1.Queries.List;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class NotificationsV1 : INotificationsV1
{
    private readonly IMediator _mediator;
    public NotificationsV1(IMediator mediator) => _mediator = mediator;

    public async Task<IEnumerable<NotificationListItem>> List(string userId, CancellationToken cancellationToken) => await _mediator.Send(new NotificationListRequest(userId), cancellationToken);
}