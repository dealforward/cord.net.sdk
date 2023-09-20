namespace Cord.SDK.Infrastructure.Services;
internal sealed class NotificationsContainer : INotificationsContainer
{
    public NotificationsContainer(INotificationsV1 v1)
    {
        V1 = v1;
    }
    public INotificationsV1 V1 { get; }
}