using Cord.SDK.Application.Organizations.V1.Commands.AddMembers;
using Cord.SDK.Application.Organizations.V1.Commands.CreateOrUpdate;
using Cord.SDK.Application.Organizations.V1.Commands.RemoveMembers;
using Cord.SDK.Application.Organizations.V1.Commands.UpdateMembers;
using Cord.SDK.Application.Organizations.V1.Queries.Get;
using Cord.SDK.Application.Organizations.V1.Queries.List;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class OrganizationsV1 : IOrganizationsV1
{
    private readonly IMediator _mediator;

    public OrganizationsV1(IMediator mediator) => _mediator = mediator;

    public async Task<CordResponse?> CreateOrUpdate(string id, OrganizationPutItem item,
        CancellationToken cancellationToken) =>
        await _mediator.Send(new OrganizationCreateOrUpdateRequest(id, item), cancellationToken);

    public async Task<IEnumerable<UserListItem>?> UpdateMembers(string id, OrganizationUpdateMembers members,
        CancellationToken cancellationToken) =>
        await _mediator.Send(new OrganizationUpdateMembersRequest(id, members), cancellationToken);

    public async Task<IEnumerable<UserListItem>?> AddMembers(string id, IEnumerable<string> members,
        CancellationToken cancellationToken) =>
        await _mediator.Send(new OrganizationAddMembersRequest(id, members), cancellationToken);

    public async Task<IEnumerable<UserListItem>?> RemoveMembers(string id, IEnumerable<string> members,
        CancellationToken cancellationToken) =>
        await _mediator.Send(new OrganizationRemoveMembersRequest(id, members), cancellationToken);

    public async Task<IEnumerable<OrganizationListItem>?> List(CancellationToken cancellationToken) =>
        await _mediator.Send(new OrganizationListRequest(), cancellationToken);

    public async Task<OrganizationGetItem?> Get(string id, CancellationToken cancellationToken) =>
        await _mediator.Send(new OrganizationGetRequest(id), cancellationToken);
}