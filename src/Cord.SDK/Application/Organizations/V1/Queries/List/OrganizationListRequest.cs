using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Queries.List;

internal sealed record OrganizationListRequest() : IQuery<IEnumerable<OrganizationListItem>?>;