using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.GetConversationHistory.Response.Detail
{
    public class BlockElement
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("elements")]
        public ElementElementClass[] Elements { get; set; }
    }
}
