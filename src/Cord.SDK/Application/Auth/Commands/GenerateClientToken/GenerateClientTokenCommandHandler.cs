using Cord.SDK.Application.Abstractions.Messaging;
using JsonWebToken;

namespace Cord.SDK.Application.Auth.Commands.GenerateClientToken;

internal sealed class GenerateClientTokenCommandHandler : ICommandHandler<GenerateClientTokenCommand, string>
{
    private readonly CordSdkOptions _cordSdkOptions;

    public GenerateClientTokenCommandHandler(CordSdkOptions cordSdkOptions)
    {
        _cordSdkOptions = cordSdkOptions;
    }

    public Task<string> Handle(GenerateClientTokenCommand request, CancellationToken cancellationToken)
    {
        var descriptor = new JwsDescriptor(_cordSdkOptions.Secret.ToSigningKey(), SignatureAlgorithm.HS256)
        {
            Payload = new JsonWebToken.JwtPayload
            {
                { "app_id", _cordSdkOptions.ApplicationId },
                { "user_id", request.User.UserId },
                { "organization_id", request.User.OrganizationId },
                { "user_details", request.User.UserDetail},
                // { "organization_details",  user.OrganizationDetail},
                { JsonWebToken.JwtClaimNames.Iat, (int) (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds },
                { JsonWebToken.JwtClaimNames.Exp, (int) (DateTime.UtcNow.AddMinutes(_cordSdkOptions.ClientTokenExpiration) - new DateTime(1970, 1, 1)) .TotalSeconds },
            }
        };
        return Task.FromResult(descriptor.WriteToken());
    }
}