namespace Cord.SDK.Exceptions;

public sealed class OrganizationNotFoundException : CordException
{
    public OrganizationNotFoundException(string message) : base(message, ExceptionCodes.OrganizationNotFound,
        "The request references an organization ID which has not yet been created.")
    {
    }
}