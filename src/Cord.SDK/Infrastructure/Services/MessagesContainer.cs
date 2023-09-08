namespace Cord.SDK.Infrastructure.Services;

internal sealed class MessagesContainer : IMessagesContainer
{

    public MessagesContainer(IMessagesV1 v1)
    {
        V1 = v1;
    }

    public IMessagesV1 V1 { get; }
}