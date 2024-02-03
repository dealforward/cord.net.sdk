using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Groups.V1.Queries.Get;

internal sealed record GroupGetRequest(string Id) : IQuery<GroupGetItem?>;