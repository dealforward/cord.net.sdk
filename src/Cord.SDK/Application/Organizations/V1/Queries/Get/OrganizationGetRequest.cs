using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Queries.Get;

internal sealed record OrganizationGetRequest(string Id) : IQuery<OrganizationGetItem?>;