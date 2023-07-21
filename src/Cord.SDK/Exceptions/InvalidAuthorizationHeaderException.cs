namespace Cord.SDK.Exceptions;

public sealed class InvalidAuthorizationHeaderException : CordException
{
    public InvalidAuthorizationHeaderException(string message) : base(message,
        ExceptionCodes.InvalidAuthorizationHeader,
        "The Authorization header is either not a valid JWT or is missing the Bearer prefix.")
    {
    }
}