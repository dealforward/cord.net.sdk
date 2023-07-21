using Cord.SDK.Application.Users.V1.Commands.CreateOrUpdate;
using Cord.SDK.Application.Users.V1.Queries.Get;
using Cord.SDK.Application.Users.V1.Queries.List;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class UsersV1 : IUsersV1
{
    private readonly IMediator _mediator;

    public UsersV1(IMediator mediator) => _mediator = mediator;

    public async Task<IEnumerable<UserListItem>> List(UserListFilter? filter, CancellationToken cancellationToken) =>
        await _mediator.Send(new UserListRequest(filter), cancellationToken);

    public async Task<CordResponse?> UpdateOrCreate(string id, UserPutItem item, CancellationToken cancellationToken) =>
        await _mediator.Send(new UserCreateOrUpdateRequest(id, item), cancellationToken);

    public async Task<UserGetItem?> Get(string id, CancellationToken cancellationToken) =>
        await _mediator.Send(new UserGetRequest(id), cancellationToken);
}