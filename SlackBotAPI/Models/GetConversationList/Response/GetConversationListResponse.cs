using SlackBotAPI.Models.GetConversationList.Response.Details;
using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.GetConversationList.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class GetConversationListResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("channels")]
        public Channel[] Channels { get; set; }

        [JsonPropertyName("response_metadata")]
        public ResponseMetadata ResponseMetadata { get; set; }
    }
}
