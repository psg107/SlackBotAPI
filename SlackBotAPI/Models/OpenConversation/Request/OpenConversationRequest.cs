using SlackBotAPI.Attributes;

namespace SlackBotAPI.Models.OpenConversation.Request
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
