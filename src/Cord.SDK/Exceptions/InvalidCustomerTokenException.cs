namespace Cord.SDK.Exceptions;

public sealed class InvalidCustomerTokenException : CordException
{
    public InvalidCustomerTokenException(string message) : base(message, ExceptionCodes.InvalidCustomerToken,
        "The customer token is not a valid JWT or is signed incorrectly.")
    {
    }
}