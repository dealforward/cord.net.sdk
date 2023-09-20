using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Notifications.V1.Queries.List;

internal sealed record NotificationListRequest(string UserId) : IQuery<IEnumerable<NotificationListItem>>;