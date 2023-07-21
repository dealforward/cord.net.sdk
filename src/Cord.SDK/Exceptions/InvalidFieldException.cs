namespace Cord.SDK.Exceptions;

public sealed class InvalidFieldException : CordException
{
    public InvalidFieldException(string message) : base(message, ExceptionCodes.InvalidField,
        "A field is present in the request but is not one of the required or optional fields.")
    {
    }
}