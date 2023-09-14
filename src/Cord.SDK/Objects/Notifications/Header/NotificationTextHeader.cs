using Newtonsoft.Json;

namespace Cord.SDK.Objects;

public sealed class NotificationTextHeader : NotificationHeader
{
    public NotificationTextHeader()
    {
        Type = NotificationTextHeaderType.Text;
    }
    /// <summary>
    /// The text to display. 
    /// This text may start and/or end with whitespace, which should typically not be trimmed. 
    /// For example, in order to display the notification "Alice replied to your thread.", 
    /// this would typically be composed of two nodes -- a user node for Alice, 
    /// and then a text node containing " replied to your thread.", with a meaningful space at the front, 
    /// to separate this node from Alice's name.
    /// </summary>
    [JsonProperty("text")] public string? Text { get; set; }
    /// <summary>
    /// Whether the text should be formatted in bold.
    /// </summary>
    [JsonProperty("bold")] public bool Bold { get; set; }
}
