using Cord.SDK.Exceptions;
using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IUsersV1
{
    /// <summary>
    /// List all users from Cord. It uses the Rest API for this.
    /// </summary>
    /// <param name="filter">Request filtering</param>
    /// <param name="cancellationToken">For Cancellation Request.</param>
    /// <returns>User List</returns>
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
    Task<IEnumerable<UserListItem>> List(UserListFilter? filter, CancellationToken cancellationToken);

    /// <summary>
    /// According to the Id value sent, if the user exists on the Cord, it is updated with the payload. If not, a new user record is created with payload and id.
    /// </summary>
    /// <param name="id">User Id</param>
    /// <param name="item">User item</param>
    /// <param name="cancellationToken">For Cancellation Request.</param>
    /// <returns>Cord Response</returns>
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
    Task<CordResponse?> UpdateOrCreate(string id, UserPutItem item, CancellationToken cancellationToken);
    /// <summary>
    /// According to the Id value sent, the user's detail information is returned as nullable. 
    /// </summary>
    /// <param name="id">User Id</param>
    /// <param name="cancellationToken">For Cancellation Request.</param>
    /// <returns>User Item or null</returns>
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
    Task<UserGetItem?> Get(string id, CancellationToken cancellationToken);
}