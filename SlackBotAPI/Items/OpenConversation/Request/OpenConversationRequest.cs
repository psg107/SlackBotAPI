using SlackBotAPI.Attributes;

namespace SlackBotAPI.Items.OpenConversation.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class OpenConversationRequest
    {
        [QueryString("users")]
        public string Users { get; set; }
    }
}
