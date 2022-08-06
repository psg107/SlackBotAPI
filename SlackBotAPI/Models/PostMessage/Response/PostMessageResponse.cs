using SlackBotAPI.Models.PostMessage.Response.Details;
using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.PostMessage.Response
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
