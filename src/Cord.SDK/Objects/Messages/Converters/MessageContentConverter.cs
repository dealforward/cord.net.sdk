using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cord.SDK.Objects.Messages.Converters;



internal sealed class MessageContentConverter : JsonConverter
{
    public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        JObject jsonObject = JObject.Load(reader);
        var typeName = jsonObject["type"]?.Value<string?>();
        MessageContent target = typeName switch
        {
            "mention" => new MentionContent(""),
            "p" => new PackageContent(),
            _ => new TextContent("")
        };

        serializer.Populate(jsonObject.CreateReader(), target);
        return target;
    }

    public override bool CanWrite
    {
        get { return false; }
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override bool CanConvert(Type objectType) => objectType == typeof(MessageContent);
}