using System.Text.Json.Serialization;

namespace SlackBotAPI.Items.GetUserList.Response.Details
{
    public class Profile
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("skype")]
        public string Skype { get; set; }

        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        [JsonPropertyName("real_name_normalized")]
        public string RealNameNormalized { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("display_name_normalized")]
        public string DisplayNameNormalized { get; set; }

        [JsonPropertyName("fields")]
        public object Fields { get; set; }

        [JsonPropertyName("status_text")]
        public string StatusText { get; set; }

        [JsonPropertyName("status_emoji")]
        public string StatusEmoji { get; set; }

        [JsonPropertyName("status_emoji_display_info")]
        public object[] StatusEmojiDisplayInfo { get; set; }

        [JsonPropertyName("status_expiration")]
        public long StatusExpiration { get; set; }

        [JsonPropertyName("avatar_hash")]
        public string AvatarHash { get; set; }

        [JsonPropertyName("always_active")]
        public bool AlwaysActive { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("image_24")]
        public Uri Image24 { get; set; }

        [JsonPropertyName("image_32")]
        public Uri Image32 { get; set; }

        [JsonPropertyName("image_48")]
        public Uri Image48 { get; set; }

        [JsonPropertyName("image_72")]
        public Uri Image72 { get; set; }

        [JsonPropertyName("image_192")]
        public Uri Image192 { get; set; }

        [JsonPropertyName("image_512")]
        public Uri Image512 { get; set; }

        [JsonPropertyName("status_text_canonical")]
        public string StatusTextCanonical { get; set; }

        [JsonPropertyName("team")]
        public string Team { get; set; }
    }
}
