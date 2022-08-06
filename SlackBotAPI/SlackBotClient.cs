using SlackBotAPI.Defines.Conversations;
using SlackBotAPI.Helpers;
using SlackBotAPI.Models.GetConversationHistory.Request;
using SlackBotAPI.Models.GetConversationHistory.Response;
using SlackBotAPI.Models.GetConversationList.Request;
using SlackBotAPI.Models.GetConversationList.Response;
using SlackBotAPI.Models.GetUserList.Response;
using SlackBotAPI.Models.OpenConversation.Request;
using SlackBotAPI.Models.OpenConversation.Response;
using SlackBotAPI.Models.PostMessage.Request;
using SlackBotAPI.Models.PostMessage.Response;

namespace SlackBotAPI
{
    public class SlackBotClient
    {
        private readonly HttpClientWrapper client;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        public SlackBotClient(string token)
        {
            this.client = new HttpClientWrapperBuilder()
                .SetBaseAddress("https://slack.com/api/")
                .SetAuthorization("Bearer", token)
                .Build();
        }

        /// <summary>
        /// 사용자 정보 조회 <para/>
        /// https://api.slack.com/methods/users.list
        /// </summary>
        /// <returns></returns>
        public async Task<GetUserListResponse> GetUserList()
            => await client.Request<GetUserListResponse>(HttpMethod.Get, "users.list");

        /// <summary>
        /// 메시지 전송 <para/>
        /// https://api.slack.com/methods/chat.postMessage
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<PostMessageResponse> PostMessage(string channelId, string text)
            => await client.Request<PostMessageRequest, PostMessageResponse>(HttpMethod.Post, "chat.postMessage", new PostMessageRequest
            {
                Channel = channelId,
                Text = text
            });

        /// <summary>
        /// 대화 목록 조회 <para/>
        /// https://api.slack.com/methods/conversations.list
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public async Task<GetConversationListResponse> GetConversationList(string types = ConversationType.IM)
            => await client.Request<GetConversationListRequest, GetConversationListResponse>(HttpMethod.Get, "conversations.list", new GetConversationListRequest
            {
                Types = types
            });

        /// <summary>
        /// 대화창 열기
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public async Task<OpenConversationResponse> OpenConversation(string users) 
            => await client.Request<OpenConversationRequest, OpenConversationResponse>(HttpMethod.Post, "conversations.open", new OpenConversationRequest
            {
                Users = users
            });

        /// <summary>
        /// 대화 히스토리 보기
        /// </summary>
        /// <param name="channelId"></param>
        /// <returns></returns>
        public async Task<GetConversationRequestResponse> GetConversationHistory(string channelId)
            => await client.Request<GetConversationRequestRequest, GetConversationRequestResponse>(HttpMethod.Post, "conversations.history", new GetConversationRequestRequest
            {
                Channel = channelId
            });
    }
}
