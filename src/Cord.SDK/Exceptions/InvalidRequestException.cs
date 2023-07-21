namespace Cord.SDK.Exceptions;

public sealed class InvalidRequestException : CordException
{
    public InvalidRequestException(string message) : base(message, ExceptionCodes.InvalidRequest,
        "The request body is not a valid JSON object or is empty.")
    {
    }
}