using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Users.V1.Commands.CreateOrUpdate;

internal sealed record UserCreateOrUpdateRequest(string Id, UserPutItem Item) : ICommand<CordResponse?>;