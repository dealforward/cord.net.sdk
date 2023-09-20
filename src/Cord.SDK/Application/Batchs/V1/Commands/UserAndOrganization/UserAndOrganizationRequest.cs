using Cord.SDK.Application.Abstractions.Messaging;
using Cord.SDK.Objects;

namespace Cord.SDK.Application.Batchs.V1.Commands.UserAndOrganization;

internal sealed record UserAndOrganizationRequest(BatchUserAndOrganizationItem Item) : ICommand<CordResponse>;