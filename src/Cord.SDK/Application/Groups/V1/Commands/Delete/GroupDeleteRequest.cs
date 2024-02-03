using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.Delete;

internal sealed record GroupDeleteRequest(string Id) : ICommand<CordResponse?>;