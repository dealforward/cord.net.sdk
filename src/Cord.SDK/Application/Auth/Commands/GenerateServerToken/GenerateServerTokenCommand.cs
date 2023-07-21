using Cord.SDK.Application.Abstractions.Messaging;

namespace Cord.SDK.Application.Auth.Commands.GenerateServerToken;

internal sealed record GenerateServerTokenCommand : ICommand<string>;