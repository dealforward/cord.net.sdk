using Cord.SDK.Application.Abstractions.Messaging;
using JsonWebToken;
using Microsoft.Extensions.Options;

namespace Cord.SDK.Application.Auth.Commands.GenerateServerToken;

internal sealed class GenerateServerTokenCommandHandler : ICommandHandler<GenerateServerTokenCommand, string>
{
    private readonly CordSdkOptions _cordSdkOptions;

    public GenerateServerTokenCommandHandler(IOptions<CordSdkOptions> cordSdkOptions)
    {
        _cordSdkOptions = cordSdkOptions.Value;
    }

    public Task<string> Handle(GenerateServerTokenCommand request, CancellationToken cancellationToken)
    {
        var descriptor = new JwsDescriptor(_cordSdkOptions.Secret.ToSigningKey(), SignatureAlgorithm.HS512)
        {
            Payload = new JwtPayload
            {
                { "app_id", _cordSdkOptions.ApplicationId },
                { JwtClaimNames.Iat, (int) (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds },
                { JwtClaimNames.Exp, (int) (DateTime.UtcNow.AddMinutes(_cordSdkOptions.ServerTokenExpiration) - new DateTime(1970, 1, 1)).TotalSeconds },
            }
        };
        return Task.FromResult(descriptor.WriteToken());
    }
}