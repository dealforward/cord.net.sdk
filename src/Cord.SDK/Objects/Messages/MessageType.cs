using System.Runtime.Serialization;

namespace Cord.SDK.Objects;

public enum MessageType
{
    [EnumMember(Value = "action_message")] ActionMessage,
    [EnumMember(Value = "user_message")] UserMessage
}
