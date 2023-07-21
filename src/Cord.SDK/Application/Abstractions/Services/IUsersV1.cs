using Cord.SDK.Exceptions;
using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IUsersV1
{
    /// <summary>
    /// List all users from Cord. It uses the Rest API for this.
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="cancellationToken"></param>
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
    /// Creates or updates a user record.
    /// </summary>
    /// <param name="id">Id value of the user record.</param>
    /// <param name="item">User item</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Cord Response</returns>
    Task<CordResponse?> UpdateOrCreate(string id, UserPutItem item, CancellationToken cancellationToken);
    /// <summary>
    /// Finds a user
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>User Item or null</returns>
    Task<UserGetItem?> Get(string id, CancellationToken cancellationToken);
}