using SlackBotAPI.Attributes;

namespace SlackBotAPI.Items.GetConversationList.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class GetConversationListRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [QueryString("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [QueryString("exclude_archived")]
        public bool? ExcludeArchived { get; set; }

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

        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="SlackBotAPI.Defines.Conversations.ConversationType"/>
        [QueryString("types")]
        public string Types { get; set; }
    }
}
