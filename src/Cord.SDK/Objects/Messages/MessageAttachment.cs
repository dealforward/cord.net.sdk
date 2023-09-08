using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public abstract class MessageAttachment : IAttachment
{
    /// <summary>
    /// The ID of this attachment.
    /// </summary>
    [JsonProperty("id")] public string Id { get; set; } = null!;
    /// <summary>
    /// The name of the file that was attached.
    /// </summary>
    [JsonProperty("name")] public string Name { get; set; } = null!;
    /// <summary>
    /// The URL that a user can use to download the file. This is a signed URL that will expire after 24 hours.
    /// </summary>
    [JsonProperty("url")] public string Url { get; set; } = null!;
    /// <summary>
    /// The MIME type of the file.
    /// </summary>
    [JsonProperty("mimeType")] public string MimeType { get; set; } = null!;
    /// <summary>
    /// The size of the file, in bytes.
    /// </summary>
    [JsonProperty("size")] public long Size { get; set; }
    /// <summary>
    /// The status of the file upload. 
    /// uploading means that the user has not yet completed uploading the file, uploaded means the file is successfully uploaded, failed means the upload encountered an error, and cancelled means the user cancelled the upload before it was finished.
    /// </summary>
    [JsonProperty("uploadStatus")] public MessageAttachmentUploadStatus UploadStatus { get; set; }
}
