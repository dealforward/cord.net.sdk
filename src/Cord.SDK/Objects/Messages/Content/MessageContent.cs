using Cord.SDK.Objects.Messages.Converters;
using Newtonsoft.Json;

namespace Cord.SDK.Objects;

[JsonConverter(typeof(MessageContentConverter))]
public class MessageContent
{
}
