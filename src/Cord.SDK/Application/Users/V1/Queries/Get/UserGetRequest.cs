using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Users.V1.Queries.Get;

internal sealed record UserGetRequest(string Id) : IQuery<UserGetItem?>;