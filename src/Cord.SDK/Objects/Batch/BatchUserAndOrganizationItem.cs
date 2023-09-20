using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class BatchUserAndOrganizationItem
{
    public sealed class User
    {
        public User(string id) => Id = id;
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("email")] public string? Email { get; set; }
    }

    public sealed class Organization
    {
        public Organization(string id, string name)
        {
            Id = id;
            Name = name;
        }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("members")] public IEnumerable<string>? Members { get; set; }
    }

    public BatchUserAndOrganizationItem(IEnumerable<User> users) => Users = users;
    public BatchUserAndOrganizationItem(IEnumerable<Organization> organizations) => Organizations = organizations;
    public BatchUserAndOrganizationItem(IEnumerable<User> users, IEnumerable<Organization> organizations)
    {
        Users = users;
        Organizations = organizations;
    }

    [JsonProperty("users")] public IEnumerable<User>? Users { get; set; }
    [JsonProperty("organizations")] public IEnumerable<Organization>? Organizations { get; set; }
}
