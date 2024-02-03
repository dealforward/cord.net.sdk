using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Queries.Get;

[Obsolete("Please use the group API instead of this.")]
internal sealed record OrganizationGetRequest(string Id) : IQuery<OrganizationGetItem?>;