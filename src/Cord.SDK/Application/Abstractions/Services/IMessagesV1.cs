using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IMessagesV1
{
    /// <summary>
    /// This endpoint returns information about all messages in a thread.
    /// </summary>
    /// <param name="threadId">Thread Id</param>
    /// <param name="direction">Return messages in ascending or descending order of creation timestamp. 'descending' is the default.</param>
    /// <param name="cancellationToken"></param>
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
    Task<IEnumerable<MessageListItem>> List(string threadId, MessageListShortDirection? direction, CancellationToken cancellationToken);
}