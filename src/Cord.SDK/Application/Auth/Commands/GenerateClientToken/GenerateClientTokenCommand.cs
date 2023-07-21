using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Auth.Commands.GenerateClientToken;

internal sealed record GenerateClientTokenCommand(CordAuthTokenUser User) : ICommand<string>;