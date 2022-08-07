namespace SlackBotAPI.Defines.Conversations
{
    /// <summary>
    /// 대화 타입
    /// </summary>
    public class ConversationType
    {
        /// <summary>
        /// 공개채널
        /// </summary>
        public const string PublicChannel = "public_channel";

        /// <summary>
        /// 비공개채널
        /// </summary>
        public const string PrivateChannel = "private_channel";

        /// <summary>
        /// multiparty IM (Multiple DM)
        /// </summary>
        public const string MPIM = "mpim";

        /// <summary>
        /// Direct Message
        /// </summary>
        public const string IM = "im";
    }
}
