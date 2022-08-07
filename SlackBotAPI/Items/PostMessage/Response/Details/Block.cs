using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.PostMessage.Response.Details
{
    public class Block
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("block_id")]
        public string BlockId { get; set; }

        [JsonPropertyName("elements")]
        public BlockElement[] Elements { get; set; }
    }
}
