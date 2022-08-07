using SlackBotAPI.Items.PostMessage.Response.Details;
using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.PostMessage.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class PostMessageResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("ts")]
        public string Ts { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}
