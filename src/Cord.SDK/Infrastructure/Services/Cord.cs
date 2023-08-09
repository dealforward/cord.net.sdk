namespace Cord.SDK.Infrastructure.Services;

internal sealed class Cord : ICord
{
    public Cord
    (
        IThreadsContainer threadsContainer,
        ITokenGenerator tokenGenerator,
        IUsersContainer usersContainer,
        IOrganizationsContainer organizations,
        IMessagesContainer messages
    )
    {
        TokenGenerator = tokenGenerator;
        Threads = threadsContainer;
        Users = usersContainer;
        Organizations = organizations;
        Messages = messages;
    }

    public ITokenGenerator TokenGenerator { get; }
    public IThreadsContainer Threads { get; }
    public IUsersContainer Users { get; }
    public IOrganizationsContainer Organizations { get; }
    public IMessagesContainer Messages { get; }
}