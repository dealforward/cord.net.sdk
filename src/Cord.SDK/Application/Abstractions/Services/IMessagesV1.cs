using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IMessagesV1
{
    /// <summary>
    /// This method returns information about all messages in a thread.
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

    /// <summary>
    /// This method returns information about a single message.
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
    Task<MessageListItem?> Get(string threadId, string messageId, CancellationToken cancellationToken);
    
    /// <summary>
    /// This method returns information about a single message.
    /// </summary>
    /// <param name="threadId">Thread Id</param>
    /// <param name="item"></param>
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
    Task<CordResponse> Post(string threadId, MessagePostItem item, CancellationToken cancellationToken);

    /// <summary>
    /// This method deletes a message.
    /// </summary>
    /// <param name="threadId">Thread Id</param>
    /// <param name="messageId"></param>
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
    Task<CordResponse> Delete(string threadId, string messageId, CancellationToken cancellationToken);
}