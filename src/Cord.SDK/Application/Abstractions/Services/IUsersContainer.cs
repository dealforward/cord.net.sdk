namespace Cord.SDK;

public interface IUsersContainer
{
    /// <summary>
    /// REST API of version 1
    /// </summary>
    /// <value></value>
    IUsersV1 V1 { get; }
}