using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Threads.V1.Queries.Get;

internal sealed record ThreadGetRequest(string Id) : IQuery<ThreadGetItem?>;