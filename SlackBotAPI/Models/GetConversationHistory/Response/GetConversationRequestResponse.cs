using SlackBotAPI.Models.GetConversationHistory.Response.Detail;
using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.GetConversationHistory.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class GetConversationRequestResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("messages")]
        public Message[] Messages { get; set; }

        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        [JsonPropertyName("is_limited")]
        public bool IsLimited { get; set; }

        [JsonPropertyName("pin_count")]
        public long PinCount { get; set; }

        [JsonPropertyName("channel_actions_ts")]
        public object ChannelActionsTs { get; set; }

        [JsonPropertyName("channel_actions_count")]
        public long ChannelActionsCount { get; set; }
    }
}
