using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.PostMessage.Response.Details
{
    public class ElementElementClass
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
