
namespace Cord.SDK.Application.Abstractions.HttpRequest;

internal interface IRestClient
{
   Task<TResponse?> Get<TResponse>(string uri, CancellationToken cancellationToken = default);
   Task<TResponse?> Get<TResponse>(string uri, IEnumerable<(string key, string value, bool? encode)> queryParams, CancellationToken cancellationToken = default);
   Task<TResponse?> Put<TResponse, TBody>(string uri, TBody body, CancellationToken cancellationToken);
   Task<TResponse?> Post<TResponse, TBody>(string uri, TBody body, CancellationToken cancellationToken);
   Task<TResponse?> Delete<TResponse>(string uri, CancellationToken cancellationToken);
}