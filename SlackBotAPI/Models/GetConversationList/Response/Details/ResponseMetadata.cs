using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.GetConversationList.Response.Details
{
    public class ResponseMetadata
    {
        [JsonPropertyName("next_cursor")]
        public string NextCursor { get; set; }
    }
}
