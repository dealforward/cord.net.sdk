using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum MessageAttachmentUploadStatus
{
    [EnumMember(Value = "uploading")] Uploading,
    [EnumMember(Value = "uploaded")] Uploaded,
    [EnumMember(Value = "failed")] Failed,
    [EnumMember(Value = "cancelled")] Cancelled
}
