using Cord.SDK.Application.Batchs.V1.Commands.UserAndOrganization;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class BatchesV1 : IBatchesV1
{
    private readonly IMediator _mediator;

    public BatchesV1(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<CordResponse> UserAndOrganization(BatchUserAndOrganizationItem item, CancellationToken cancellationToken) => await _mediator.Send(new UserAndOrganizationRequest(item), cancellationToken);
}