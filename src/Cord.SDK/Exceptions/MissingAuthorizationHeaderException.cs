namespace Cord.SDK.Exceptions;

public sealed class MissingAuthorizationHeaderException : CordException
{
    public MissingAuthorizationHeaderException(string message) : base(message,
        ExceptionCodes.MissingAuthorizationHeader,
        "The request references an organization ID which has not yet been created.")
    {
    }
}