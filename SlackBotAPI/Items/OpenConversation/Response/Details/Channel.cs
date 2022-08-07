using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.OpenConversation.Response.Details
{
    public partial class Channel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
