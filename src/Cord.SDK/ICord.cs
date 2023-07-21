namespace Cord.SDK;

public interface ICord
{
    ITokenGenerator TokenGenerator { get; }
    IThreadsContainer Threads { get; }
    IUsersContainer Users { get; }
    IOrganizationsContainer Organizations { get; }
}