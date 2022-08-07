using SlackBotAPI.Items.OpenConversation.Response.Details;
using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.OpenConversation.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class OpenConversationResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("no_op")]
        public bool NoOp { get; set; }

        [JsonPropertyName("already_open")]
        public bool AlreadyOpen { get; set; }

        [JsonPropertyName("channel")]
        public Channel Channel { get; set; }
    }
}
