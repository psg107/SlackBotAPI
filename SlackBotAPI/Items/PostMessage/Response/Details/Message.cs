using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.PostMessage.Response.Details
{
    public class Message
    {
        [JsonPropertyName("bot_id")]
        public string BotId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("user")]
        public string User { get; set; }

        [JsonPropertyName("ts")]
        public string Ts { get; set; }

        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        [JsonPropertyName("team")]
        public string Team { get; set; }

        [JsonPropertyName("bot_profile")]
        public BotProfile BotProfile { get; set; }

        [JsonPropertyName("blocks")]
        public Block[] Blocks { get; set; }
    }
}
