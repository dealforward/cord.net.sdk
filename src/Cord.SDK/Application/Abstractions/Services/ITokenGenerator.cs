using Cord.SDK.Objects;

namespace Cord.SDK;

public interface ITokenGenerator
{
    /// <summary>
    /// Generates JWT Token for Rest API access with the configured `ApplicationId` and `Secret` information.
    /// </summary>
    /// <returns>JWT Token</returns>
    string GenerateServerToken();
    
    /// <summary>
    /// It generates a JWT Token that users use in the WebSocket they connect to in order to participate in the Chat.
    /// </summary>
    /// <param name="user">User to connect to chat</param>
    /// <returns>JWT Token</returns>
    string GenerateClientToken(CordAuthTokenUser user);
}