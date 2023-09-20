using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IBatchesV1
{
    /// <summary>
    /// Use this for cases where you need to take actions on several organizations or users at once. 
    /// The action taken for each entity is 'create or update': 
    /// If an existing user or organization with that ID exists, it will be updated with the provided data.
    /// </summary>
    /// <param name="item">Post request item</param>
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
    Task<CordResponse> UserAndOrganization(BatchUserAndOrganizationItem item, CancellationToken cancellationToken);
}