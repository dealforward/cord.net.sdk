using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class MessageFileAttachment : MessageAttachment
{
    /// <summary>
    /// The type of this attachment, which is always file for file attachments.
    /// </summary>
    /// <value></value>
    [JsonProperty("type")] public string Type { get; set; } = "file";
    /// <summary>
    /// (Optional) The text that was selected when creating the annotation.
    /// </summary>
    [JsonProperty("textContent")] public string? TextContent { get; set; }
}
