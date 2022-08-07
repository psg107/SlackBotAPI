using SlackBotAPI.Attributes;

namespace SlackBotAPI.Items.GetUserList.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class GetUserListRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [QueryString("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [QueryString("include_locale")]
        public bool? IncludeLocale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [QueryString("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [QueryString("team_id")]
        public string TeamId { get; set; }
    }
}
