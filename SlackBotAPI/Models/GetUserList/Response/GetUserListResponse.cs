using SlackBotAPI.Models.GetUserList.Response.Details;
using System.Text.Json.Serialization;

namespace SlackBotAPI.Models.GetUserList.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class GetUserListResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("members")]
        public Member[] Members { get; set; }
    }
}
