using Cord.SDK.Objects;
using Cord.SDK.Exceptions;

namespace Cord.SDK;

public interface IOrganizationsV1
{
    /// <summary>
    /// According to the Id value sent, if the organization exists, it is updated with the payload. Otherwise, a new organization is created with the payload and Id value.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="item">Request payload</param>
    /// <param name="cancellationToken">For Cancellation Request</param>
    /// <returns cref="CordResponse?">Cord Response of operation</returns>
    /// <exception cref="InvalidRequestException"></exception>
    /// <exception cref="UnexpectedFieldException"></exception>
    /// <exception cref="InvalidFieldException"></exception>
    /// <exception cref="ApplicationNotFoundException"></exception>
    /// <exception cref="OrganizationNotFoundException"></exception>
    /// <exception cref="UserNotFoundException"></exception>
    /// <exception cref="InvalidAuthorizationHeaderException"></exception>
    /// <exception cref="MissingAuthorizationHeaderException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidCustomerTokenException"></exception>
    /// <exception cref="InvalidAccessTokenException"></exception>
    /// <exception cref="ExpiredAccessTokenException"></exception>
    /// <exception cref="CordException">Generic unknown server error.</exception>
    Task<CordResponse?> CreateOrUpdate(string id, OrganizationPutItem item, CancellationToken cancellationToken);

    /// <summary>
    /// It is used to add or remove users to the organization in bulk.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="members">Request Payload</param>
    /// <param name="cancellationToken">For Cancellation Request</param>
    /// <exception cref="InvalidRequestException"></exception>
    /// <exception cref="UnexpectedFieldException"></exception>
    /// <exception cref="InvalidFieldException"></exception>
    /// <exception cref="ApplicationNotFoundException"></exception>
    /// <exception cref="OrganizationNotFoundException"></exception>
    /// <exception cref="UserNotFoundException"></exception>
    /// <exception cref="InvalidAuthorizationHeaderException"></exception>
    /// <exception cref="MissingAuthorizationHeaderException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidCustomerTokenException"></exception>
    /// <exception cref="InvalidAccessTokenException"></exception>
    /// <exception cref="ExpiredAccessTokenException"></exception>
    /// <exception cref="CordException">Generic unknown server error.</exception>
    /// <returns>Users List</returns>
    Task<IEnumerable<UserListItem>?> UpdateMembers(string id, OrganizationUpdateMembers members,
        CancellationToken cancellationToken);

    /// <summary>
    /// It is used to add users to the organization in bulk. It uses the same API as the UpdateMembers method.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="members">Request Payload as List of UserId</param>
    /// <param name="cancellationToken">For Cancellation Request</param>
    /// <exception cref="InvalidRequestException"></exception>
    /// <exception cref="UnexpectedFieldException"></exception>
    /// <exception cref="InvalidFieldException"></exception>
    /// <exception cref="ApplicationNotFoundException"></exception>
    /// <exception cref="OrganizationNotFoundException"></exception>
    /// <exception cref="UserNotFoundException"></exception>
    /// <exception cref="InvalidAuthorizationHeaderException"></exception>
    /// <exception cref="MissingAuthorizationHeaderException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidCustomerTokenException"></exception>
    /// <exception cref="InvalidAccessTokenException"></exception>
    /// <exception cref="ExpiredAccessTokenException"></exception>
    /// <exception cref="CordException">Generic unknown server error.</exception>
    /// <returns>User List</returns>
    Task<IEnumerable<UserListItem>?> AddMembers(string id, IEnumerable<string> members,
        CancellationToken cancellationToken);

    /// <summary>
    /// Used to remove users from the organization in bulk. It uses the same API as the UpdateMembers method.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="members">Request Payload as List of UserId</param>
    /// <param name="cancellationToken">For Cancellation Request</param>
    /// <exception cref="InvalidRequestException"></exception>
    /// <exception cref="UnexpectedFieldException"></exception>
    /// <exception cref="InvalidFieldException"></exception>
    /// <exception cref="ApplicationNotFoundException"></exception>
    /// <exception cref="OrganizationNotFoundException"></exception>
    /// <exception cref="UserNotFoundException"></exception>
    /// <exception cref="InvalidAuthorizationHeaderException"></exception>
    /// <exception cref="MissingAuthorizationHeaderException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidCustomerTokenException"></exception>
    /// <exception cref="InvalidAccessTokenException"></exception>
    /// <exception cref="ExpiredAccessTokenException"></exception>
    /// <exception cref="CordException">Generic unknown server error.</exception>
    /// <returns>User List</returns>
    Task<IEnumerable<UserListItem>?> RemoveMembers(string id, IEnumerable<string> members,
        CancellationToken cancellationToken);

    /// <summary>
    /// Lists all organizations in Application.
    /// </summary>
    /// <param name="cancellationToken">For Cancellation Request</param>
    /// <exception cref="InvalidRequestException"></exception>
    /// <exception cref="UnexpectedFieldException"></exception>
    /// <exception cref="InvalidFieldException"></exception>
    /// <exception cref="ApplicationNotFoundException"></exception>
    /// <exception cref="OrganizationNotFoundException"></exception>
    /// <exception cref="UserNotFoundException"></exception>
    /// <exception cref="InvalidAuthorizationHeaderException"></exception>
    /// <exception cref="MissingAuthorizationHeaderException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidCustomerTokenException"></exception>
    /// <exception cref="InvalidAccessTokenException"></exception>
    /// <exception cref="ExpiredAccessTokenException"></exception>
    /// <exception cref="CordException">Generic unknown server error.</exception>
    /// <returns>List of Organizations</returns>
    Task<IEnumerable<OrganizationListItem>?> List(CancellationToken cancellationToken);

    /// <summary>
    /// Detailed information of the related organization according to the organization id value sent.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="cancellationToken">For Cancellation Request</param>
    /// <exception cref="InvalidRequestException"></exception>
    /// <exception cref="UnexpectedFieldException"></exception>
    /// <exception cref="InvalidFieldException"></exception>
    /// <exception cref="ApplicationNotFoundException"></exception>
    /// <exception cref="OrganizationNotFoundException"></exception>
    /// <exception cref="UserNotFoundException"></exception>
    /// <exception cref="InvalidAuthorizationHeaderException"></exception>
    /// <exception cref="MissingAuthorizationHeaderException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidAppTokenException"></exception>
    /// <exception cref="InvalidCustomerTokenException"></exception>
    /// <exception cref="InvalidAccessTokenException"></exception>
    /// <exception cref="ExpiredAccessTokenException"></exception>
    /// <exception cref="CordException">Generic unknown server error.</exception>
    /// <returns></returns>
    Task<OrganizationGetItem?> Get(string id, CancellationToken cancellationToken);
}