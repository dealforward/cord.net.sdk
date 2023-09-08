using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum MessageContentType
{
    [EnumMember(Value = "p")]
    Package,
    [EnumMember(Value = "mention")]
    Mention

}