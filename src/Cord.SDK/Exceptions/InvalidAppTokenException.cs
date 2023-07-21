namespace Cord.SDK.Exceptions;

public sealed class InvalidAppTokenException : CordException
{
    public InvalidAppTokenException(string message) : base(message, ExceptionCodes.InvalidAppToken,
        "The app token is not a valid JWT or is signed incorrectly.")
    {
    }
}