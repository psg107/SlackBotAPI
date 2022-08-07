using SlackBotAPI.Attributes;

namespace SlackBotAPI.Items.OpenConversation.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class OpenConversationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [QueryString("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [QueryString("prevent_creation")]
        public bool? PreventCreation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [QueryString("return_im")]
        public bool? ReturnIM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [QueryString("users")]
        public string Users { get; set; }
    }
}
