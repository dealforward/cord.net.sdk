using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class TextContent : MessageContent
{
    [JsonProperty("text")] public string Text { get; set; }

    [JsonConstructor]
    public TextContent(string text)
    {
        Text = text;
    }
}
