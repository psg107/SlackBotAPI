using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.GetConversationHistory.Response.Detail
{
    public class BotProfile
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("updated")]
        public long Updated { get; set; }

        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        [JsonPropertyName("icons")]
        public Icons Icons { get; set; }

        [JsonPropertyName("team_id")]
        public string TeamId { get; set; }
    }
}
