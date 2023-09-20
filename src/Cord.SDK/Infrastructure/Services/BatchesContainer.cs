namespace Cord.SDK.Infrastructure.Services;

internal sealed class BatchesContainer : IBatchesContainer
{
    public BatchesContainer(IBatchesV1 v1)
    {
        V1 = v1;
    }
    public IBatchesV1 V1 { get; }
}