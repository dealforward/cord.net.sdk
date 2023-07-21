namespace Cord.SDK.Infrastructure.Services;

internal sealed class ThreadsContainer : IThreadsContainer
{
    public ThreadsContainer(IThreadsV1 v1)
    {
        V1 = v1;
    }

    public IThreadsV1 V1 { get; }
}