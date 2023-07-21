using Cord.SDK.Objects;

namespace Cord.SDK;

public interface IThreadsV1
{
    Task<IEnumerable<ThreadListItem>> List(CancellationToken cancellationToken);
    Task<ThreadGetItem?> Get(string id, CancellationToken cancellationToken);
    Task<CordResponse?> Update(string id, ThreadPutItem item, CancellationToken cancellationToken);
}