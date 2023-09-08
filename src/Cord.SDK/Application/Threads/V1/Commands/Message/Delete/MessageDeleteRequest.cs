using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Commands.Message.Delete;

internal sealed record MessageDeleteRequest(string ThreadId, string MessageId) : ICommand<CordResponse>;