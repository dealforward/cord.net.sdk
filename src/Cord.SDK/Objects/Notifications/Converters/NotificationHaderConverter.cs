using Cord.SDK.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cord.SDK.Objects.Notifications.Converters;

internal sealed class NotificationHeaderConverter : JsonConverter
{
    public override bool CanConvert(Type objectType) => objectType == typeof(NotificationHeader);

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        JObject jsonObject = JObject.Load(reader);
        var typeName = jsonObject["type"]?.Value<string?>();
        NotificationHeader target = typeName switch
        {
           "text" => new NotificationTextHeader(),
            "user" => new NotificationUserHeader(),
            _ => throw new UnSupportedJsonConvertionException(typeName ?? "UNKNOWN")
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
}