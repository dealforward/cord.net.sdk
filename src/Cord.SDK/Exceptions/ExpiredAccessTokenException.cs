namespace Cord.SDK.Exceptions;

public sealed class ExpiredAccessTokenException : CordException
{
    public ExpiredAccessTokenException(string message) : base(message, ExceptionCodes.ExpiredAccessToken,
        "The access token is expired or has been revoked. You should request another one.")
    {
    }
}