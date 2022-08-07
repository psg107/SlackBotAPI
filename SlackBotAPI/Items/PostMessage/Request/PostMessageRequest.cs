using SlackBotAPI.Attributes;

namespace SlackBotAPI.Items.PostMessage.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class PostMessageRequest
    {
        [QueryString("channel")]
        public string Channel { get; set; }
        
        [QueryString("text")]
        public string Text { get; set; }
    }
}
