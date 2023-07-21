namespace Cord.SDK.Exceptions;

internal static class ExceptionCodes
{
    public const string InvalidRequest = "invalid_request";
    public const string UnexpectedField = "unexpected_field";
    public const string InvalidField = "invalid_field";
    public const string ApplicationNotFound = "application_not_found";
    public const string OrganizationNotFound = "organization_not_found";
    public const string UserNotFound = "user_not_found";
    public const string InvalidAuthorizationHeader = "invalid_authorization_header";
    public const string MissingAuthorizationHeader = "missing_authorization_header";
    public const string InvalidAppToken = "invalid_app_token";
    public const string InvalidCustomerToken = "invalid_customer_token";
    public const string InvalidAccessToken = "invalid_access_token";
    public const string ExpiredAccessToken = "expired_access_token";
}