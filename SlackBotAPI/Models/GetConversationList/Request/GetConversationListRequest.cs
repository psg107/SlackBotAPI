using SlackBotAPI.Attributes;

namespace SlackBotAPI.Models.GetConversationList.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class GetConversationListRequest
    {
        [QueryString("types")]
        public string Types { get; set; }
    }
}
