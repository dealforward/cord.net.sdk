namespace Cord.SDK;
public interface INotificationsContainer
{
    /// <summary>
    /// REST API of version 1
    /// </summary>
    INotificationsV1 V1 { get; }
}