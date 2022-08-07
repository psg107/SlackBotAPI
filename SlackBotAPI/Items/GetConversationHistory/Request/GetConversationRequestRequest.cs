using SlackBotAPI.Attributes;

namespace SlackBotAPI.Items.GetConversationHistory.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class GetConversationRequestRequest
    {
        [QueryString("channel")]
        public string Channel { get; set; }
    }
}
