namespace Cord.SDK.Exceptions;

public sealed class ApplicationNotFoundException : CordException
{
    public ApplicationNotFoundException(string message) : base(message, ExceptionCodes.ApplicationNotFound,
        "The referenced application ID does not exist.")
    {
    }
}