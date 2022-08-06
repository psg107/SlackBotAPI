using SlackBotAPI;
using System.Diagnostics;

const string TOKEN = "{ENTER_YOUT_BOT_TOKEN}";

//초기화
var client = new SlackBotClient(TOKEN);

//사용자 정보 조회
var userListResponse = await client.GetUserList();
var users = userListResponse.Members;
var user = users.FirstOrDefault(x => x.RealName == "박상곤");

//DM 채널 찾기
var openConversationResponse = await client.OpenConversation(user.Id);
var dmChannel = openConversationResponse.Channel;

//DM 전송
var postMessageResponse = await client.PostMessage(dmChannel.Id, "ZZZ");

Debugger.Break();