using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Notifications.V1.Commands.Create;

internal sealed record NotificationPostRequest(NotificationPostItem Item) : ICommand<CordResponse>;