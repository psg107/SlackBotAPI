using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.PostMessage.Response.Details
{
    public class BlockElement
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("elements")]
        public ElementElementClass[] Elements { get; set; }
    }
}
