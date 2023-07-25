namespace Cord.SDK;

public interface IThreadsContainer
{
    /// <summary>
    /// REST API of version 1
    /// </summary>
    /// <value></value>
    IThreadsV1 V1 { get; }
}