using Cord.SDK.Exceptions;
using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IGroupsV1
{
    /// <summary>
    /// According to the Id value sent, if the group exists, it is updated with the payload. Otherwise, a new group is created with the payload and Id value.
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
    Task<CordResponse?> CreateOrUpdate(string id, GroupPutItem item, CancellationToken cancellationToken);
    
    /// <summary>
    /// It is used to add users to the group in bulk.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="users">Request Payload</param>
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
    Task<IEnumerable<UserListItem>?> AddMembers(string id, IEnumerable<string> users,
        CancellationToken cancellationToken);
    
    /// <summary>
    /// It is used to remove users from the group in bulk.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="users">Request Payload</param>
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
    Task<IEnumerable<UserListItem>?> RemoveMembers(string id, IEnumerable<string> users,
        CancellationToken cancellationToken);
    
    /// <summary>
    /// It is used to add or remove users to the group in bulk.
    /// </summary>
    /// <param name="id">Organization Id</param>
    /// <param name="item">Request Payload</param>
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
    Task<IEnumerable<UserListItem>?> UpdateMembers(string id, GroupMemberPostItem item,
        CancellationToken cancellationToken);
    
    
    /// <summary>
    /// Lists all group in Application.
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
    Task<IEnumerable<GroupListItem>?> List(CancellationToken cancellationToken);
    
    /// <summary>
    /// Detailed information of the related group according to the organization id value sent.
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
    Task<GroupGetItem?> Get(string id, CancellationToken cancellationToken);
}