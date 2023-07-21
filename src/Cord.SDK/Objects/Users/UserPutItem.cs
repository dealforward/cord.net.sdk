using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cord.SDK.Objects;

public sealed class UserPutItem
{
    [JsonConstructor]
    public UserPutItem(string email)
    {
        Email = email;
    }

    [JsonProperty("email")] public string Email { get; set; }
    [JsonProperty("name")] public string? Name { get; set; }
    [JsonProperty("shortName")] public string? ShortName { get; set; }

    [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))]
    public UserStatus? Status { get; set; }

    [JsonProperty("profilePictureURL")] public string? ProfilePictureUrl { get; set; }
    [JsonProperty("first_name")] public string? FirstName { get; set; }
    [JsonProperty("last_name")] public string? LastName { get; set; }
    [JsonProperty("metadata")] public object? Metadata { get; set; }
}