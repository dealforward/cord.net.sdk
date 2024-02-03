using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Commands.CreateOrUpdate;

internal sealed record GroupCreateOrUpdateRequest(string Id, GroupPutItem Item) : ICommand<CordResponse?>;