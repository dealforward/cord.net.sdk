namespace Cord.SDK.Exceptions;

public sealed class InvalidAccessTokenException : CordException
{
    public InvalidAccessTokenException(string message) : base(message, ExceptionCodes.InvalidAccessToken,
        "The access token is invalid. You should request another one.")
    {
    }
}