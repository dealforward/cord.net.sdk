using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Commands.Message.Post;

internal sealed record MessagePostRequest(string ThreadId, MessagePostItem Item) : ICommand<CordResponse>;
