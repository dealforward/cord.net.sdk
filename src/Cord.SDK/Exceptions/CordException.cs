using System.Net;

namespace Cord.SDK.Exceptions;

public class CordException : Exception
{
    public string ExceptionCode { get; }
    public string ExceptionDescription { get; set; }

    protected CordException(string message, string exceptionCode, string exceptionDescription) : base(message)
    {
        ExceptionCode = exceptionCode;
        ExceptionDescription = exceptionDescription;
    }

    public static void ThrowExceptionFromHttpResponse(HttpStatusCode code, string? errCode, string? contentMessage)
    {
        if (code is HttpStatusCode.InternalServerError)
            throw new CordException("UNKOWN ERROR", "500", "internal server error");
        if (code is not (HttpStatusCode.BadRequest or HttpStatusCode.Unauthorized) || errCode is null ||
            contentMessage is null) return;
        switch (errCode)
        {
            case ExceptionCodes.InvalidRequest:
                throw new InvalidRequestException(contentMessage);
            case ExceptionCodes.UnexpectedField:
                throw new UnexpectedFieldException(contentMessage);
            case ExceptionCodes.InvalidField:
                throw new InvalidFieldException(contentMessage);
            case ExceptionCodes.ApplicationNotFound:
                throw new ApplicationException(contentMessage);
            case ExceptionCodes.OrganizationNotFound:
                throw new OrganizationNotFoundException(contentMessage);
            case ExceptionCodes.UserNotFound:
                throw new UserNotFoundException(contentMessage);
            case ExceptionCodes.InvalidAuthorizationHeader:
                throw new InvalidAuthorizationHeaderException(contentMessage);
            case ExceptionCodes.MissingAuthorizationHeader:
                throw new MissingAuthorizationHeaderException(contentMessage);
            case ExceptionCodes.InvalidAppToken:
                throw new InvalidAppTokenException(contentMessage);
            case ExceptionCodes.InvalidCustomerToken:
                throw new InvalidCustomerTokenException(contentMessage);
            case ExceptionCodes.InvalidAccessToken:
                throw new InvalidAccessTokenException(contentMessage);
            case ExceptionCodes.ExpiredAccessToken:
                throw new ExpiredAccessTokenException(contentMessage);
           
        }
    }
}