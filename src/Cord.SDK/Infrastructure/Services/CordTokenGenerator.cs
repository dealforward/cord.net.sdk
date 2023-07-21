using Cord.SDK.Application.Auth.Commands.GenerateClientToken;
using Cord.SDK.Application.Auth.Commands.GenerateServerToken;
using Cord.SDK.Objects;
using MediatR;

namespace Cord.SDK.Infrastructure.Services;

internal sealed class CordTokenGenerator : ITokenGenerator
{
    private readonly IMediator _mediator;

    public CordTokenGenerator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public string GenerateServerToken()
    {
        return _mediator.Send(new GenerateServerTokenCommand()).Result;
    }

    public string GenerateClientToken(CordAuthTokenUser user)
    {
        return _mediator.Send(new GenerateClientTokenCommand(user)).Result;
    }
}