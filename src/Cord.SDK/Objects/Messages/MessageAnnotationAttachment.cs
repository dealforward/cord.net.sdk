using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class MessageAnnotationAttachment : IAttachment
{
    /// <summary>
    /// The type of this attachment, which is always annotation for annotation attachments.
    /// </summary>
    [JsonProperty("type")] public string Type { get; set; } = "annotation";
    /// <summary>
    /// The screenshot attached to the annotation.
    /// </summary>
    [JsonProperty("screenshot")] public MessageFileScreenshotAttachment Screenshot { get; set; } = null!;
    /// <summary>
    /// (Optional) The text that was selected when creating the annotation.
    /// </summary>
    [JsonProperty("textContent")] public string? TextContent { get; set; }

}
