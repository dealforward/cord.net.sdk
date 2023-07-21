using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Commands.Update;

internal sealed record ThreadPutRequest(string Id, ThreadPutItem Item) : ICommand<CordResponse?>;