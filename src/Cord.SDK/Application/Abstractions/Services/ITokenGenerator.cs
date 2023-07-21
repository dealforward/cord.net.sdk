using Cord.SDK.Objects;

namespace Cord.SDK;

public interface ITokenGenerator
{
    string GenerateServerToken();
    string GenerateClientToken(CordAuthTokenUser user);
}