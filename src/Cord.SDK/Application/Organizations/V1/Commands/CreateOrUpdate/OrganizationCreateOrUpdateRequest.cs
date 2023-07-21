using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Organizations.V1.Commands.CreateOrUpdate;

internal sealed record OrganizationCreateOrUpdateRequest(string Id, OrganizationPutItem Item) : ICommand<CordResponse?>;