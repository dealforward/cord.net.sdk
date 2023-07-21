namespace Cord.SDK.Exceptions;

public sealed class UnexpectedFieldException : CordException
{
    public UnexpectedFieldException(string message) : base(message, ExceptionCodes.UnexpectedField,
        "A field is present in the request but is not one of the required or optional fields.")
    {
    }
}