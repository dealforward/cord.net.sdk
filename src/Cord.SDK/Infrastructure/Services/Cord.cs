namespace Cord.SDK.Infrastructure.Services;

internal sealed class Cord : ICord
{
    public Cord
    (
        IThreadsContainer threadsContainer,
        ITokenGenerator tokenGenerator,
        IUsersContainer usersContainer,
        IOrganizationsContainer organizations,
        IMessagesContainer messages,
        INotificationsContainer notifications,
        IBatchesContainer batches,
        IGroupsContainer groups
    )
    {
        TokenGenerator = tokenGenerator;
        Threads = threadsContainer;
        Users = usersContainer;
        Organizations = organizations;
        Messages = messages;
        Notifications = notifications;
        Batches = batches;
        Groups = groups;
    }

    public ITokenGenerator TokenGenerator { get; }
    public IThreadsContainer Threads { get; }
    public IUsersContainer Users { get; }
    [Obsolete("Please use the group API instead of this.")]
    public IOrganizationsContainer Organizations { get; }
    public IMessagesContainer Messages { get; }
    public INotificationsContainer Notifications { get; }
    public IBatchesContainer Batches { get; }
    public IGroupsContainer Groups { get; }
}