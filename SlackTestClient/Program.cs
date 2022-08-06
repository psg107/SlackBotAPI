using SlackBotAPI;
using SlackBotAPI.Defines.Conversations;
using System.Configuration;
using System.Diagnostics;

//설정파일
var fileMap = new ExeConfigurationFileMap
{
    ExeConfigFilename = SystemEnvironment.IsDebug
        ? "App.Debug.config"
        : "App.Release.config"
};
Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

//초기화
var token = config.AppSettings.Settings["token"].Value;
var client = new SlackBotClient(token);

//사용자 정보 조회
var userListResponse = await client.GetUserList();
var users = userListResponse.Members;
var user = users.FirstOrDefault(x => x.RealName == "박상곤");

//DM 채널 찾기
var openConversationResponse = await client.OpenConversation(user.Id);
var dmChannel = openConversationResponse.Channel;

//DM 전송
//var postMessageResponse = await client.PostMessage(dmChannel.Id, "TEST");

//DM 히스토리 확인
var conversationHistoryResponse = await client.GetConversationHistory(dmChannel.Id);

//대화 목록 확인
var conversationListResponse1 = await client.GetConversationList(types: ConversationType.IM);
var conversationListResponse2 = await client.GetConversationList(types: ConversationType.PublicChannel);
var conversationListResponse3 = await client.GetConversationList(types: ConversationType.PrivateChannel);
var conversationListResponse4 = await client.GetConversationList(types: ConversationType.MPIM);

Debugger.Break();