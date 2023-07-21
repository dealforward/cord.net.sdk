using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class CordAuthTokenUser
{
    [JsonObject]
    public sealed class UserDetails
    {
        [JsonProperty("email")] public string? Email { get; set; }

        [JsonProperty("name")] public string? Name { get; set; }

        [JsonProperty("profilePictureUrl")] public string? ProfilePictureUrl { get; set; }

        public UserDetails(string? name, string? email, string? profilePictureUrl)
        {
            Name = name;
            Email = email;
            ProfilePictureUrl = profilePictureUrl;
        }
    }

    [JsonObject]
    public sealed class OrganizationDetails
    {
        [JsonProperty("name")] public string Name { get; set; }

        public OrganizationDetails(string name)
        {
            Name = name;
        }
    }

    /// <summary>
    /// The user ID can be any identifier that makes sense to your application.
    /// As long as it's unique per-user, Cord can use it to represent your user.
    /// </summary>
    /// <value></value>
    public string UserId { get; set; }

    /// <summary>
    /// Same as above. An organization ID can be any unique string. Organizations are groups of users.
    /// </summary>
    /// <value></value>
    public string OrganizationId { get; set; }

    /// <summary>
    /// By supplying the  `user_details` object, you can create the user in Cord's backend on-the-fly. No need to pre-sync your users.
    /// </summary>
    /// <value></value>
    public UserDetails UserDetail { get; set; }

    /// <summary>
    /// By supplying the `organization_details` object, just like the user, Cord will create the organization on-the-fly.
    /// </summary>
    /// <value></value>
    public OrganizationDetails? OrganizationDetail { get; set; }

    public CordAuthTokenUser
    (
        string userId,
        string organizationId,
        UserDetails userDetail,
        OrganizationDetails? organizationDetail
    )
    {
        UserId = userId;
        OrganizationId = organizationId;
        UserDetail = userDetail;
        OrganizationDetail = organizationDetail;
    }
}