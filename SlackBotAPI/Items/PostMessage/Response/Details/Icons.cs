using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.PostMessage.Response.Details
{
    public class Icons
    {
        [JsonPropertyName("image_36")]
        public Uri Image36 { get; set; }

        [JsonPropertyName("image_48")]
        public Uri Image48 { get; set; }

        [JsonPropertyName("image_72")]
        public Uri Image72 { get; set; }
    }
}
