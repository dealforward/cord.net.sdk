namespace Cord.SDK.Infrastructure.Services;

internal sealed class UsersContainer : IUsersContainer
{
    public UsersContainer(IUsersV1 v1)
    {
        V1 = v1;
    }

    public IUsersV1 V1 { get; }
}