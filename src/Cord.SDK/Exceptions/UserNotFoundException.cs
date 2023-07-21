namespace Cord.SDK.Exceptions;

public sealed class UserNotFoundException : CordException
{
    public UserNotFoundException(string message) : base(message, ExceptionCodes.UserNotFound,
        "The request references a user ID which has not yet been created.")
    {
    }
}