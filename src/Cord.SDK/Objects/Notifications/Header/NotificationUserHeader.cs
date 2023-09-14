using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class NotificationUserHeader : NotificationHeader
{
    public sealed class ClientUserData
    {
        /// <summary>
        /// The user's ID. This is unique within an application.
        /// </summary>
        [JsonProperty("id")] public string Id { get; set; } = null!;
        /// <summary>
        /// The user's name.
        /// </summary>
        [JsonProperty("name")] public string? Name { get; set; }
        /// <summary>
        /// The user's short name. In most cases, Cord components will prefer using this name over name when set.
        /// </summary>
        [JsonProperty("shortName")] public string? ShortName { get; set; }
        /// <summary>
        /// A URL to the user's profile picture.
        /// </summary>
        [JsonProperty("profilePictureURL")] public string? ProfilePictureURL { get; set; }
        /// <summary>
        /// Any metadata that has been set for the user.
        /// </summary>
        [JsonProperty("metadata")] public object? Metadata { get; set; }
    }
    public NotificationUserHeader()
    {
        Type = NotificationTextHeaderType.User;
    }
    public NotificationUserHeader(ClientUserData user)
    {
        User = user;
        Type = NotificationTextHeaderType.User;
    }
    public ClientUserData User { get; set; } = null!;
}
