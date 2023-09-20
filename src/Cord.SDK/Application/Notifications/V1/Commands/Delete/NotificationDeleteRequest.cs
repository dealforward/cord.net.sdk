using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Notifications.V1.Commands.Delete;

internal sealed record NotificationDeleteRequest(string Id) : ICommand<CordResponse>;