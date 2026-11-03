namespace Steamworks;

[Token(Token = "0x2000006")]
public static class SteamFriends
{

	[Address(RVA = "0x5DAAD0", Offset = "0x5D9ED0", Length = "0x102")]
	[Token(Token = "0x6000063")]
	public static void ActivateGameOverlay(string pchDialog) { }

	[Address(RVA = "0x5DA790", Offset = "0x5D9B90", Length = "0x4E")]
	[Token(Token = "0x6000068")]
	public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5DA680", Offset = "0x5D9A80", Length = "0x102")]
	[Token(Token = "0x6000092")]
	public static void ActivateGameOverlayInviteDialogConnectString(string pchConnectString) { }

	[Address(RVA = "0x5DA7E0", Offset = "0x5D9BE0", Length = "0x4E")]
	[Token(Token = "0x6000090")]
	public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5DA830", Offset = "0x5D9C30", Length = "0x5A")]
	[Token(Token = "0x6000066")]
	public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	[Address(RVA = "0x5DA890", Offset = "0x5D9C90", Length = "0x112")]
	[Token(Token = "0x6000064")]
	public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID) { }

	[Address(RVA = "0x5DA9B0", Offset = "0x5D9DB0", Length = "0x111")]
	[Token(Token = "0x6000065")]
	public static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = 0) { }

	[Address(RVA = "0x5DABE0", Offset = "0x5D9FE0", Length = "0x5C")]
	[Token(Token = "0x6000094")]
	public static bool BHasEquippedProfileItem(CSteamID steamID, ECommunityProfileItemType itemType) { }

	[Address(RVA = "0x5DAC40", Offset = "0x5DA040", Length = "0x44")]
	[Token(Token = "0x6000073")]
	public static void ClearRichPresence() { }

	[Address(RVA = "0x5DAC90", Offset = "0x5DA090", Length = "0x4E")]
	[Token(Token = "0x6000086")]
	public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	[Address(RVA = "0x5DACE0", Offset = "0x5DA0E0", Length = "0x9A")]
	[Token(Token = "0x600005E")]
	public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest) { }

	[Address(RVA = "0x5DAD80", Offset = "0x5DA180", Length = "0x8A")]
	[Token(Token = "0x600008C")]
	public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex) { }

	[Address(RVA = "0x5DAE10", Offset = "0x5DA210", Length = "0x9A")]
	[Token(Token = "0x6000080")]
	public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser) { }

	[Address(RVA = "0x5DAEB0", Offset = "0x5DA2B0", Length = "0x86")]
	[Token(Token = "0x600005D")]
	public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) { }

	[Address(RVA = "0x5DAF40", Offset = "0x5DA340", Length = "0x8A")]
	[Token(Token = "0x600005A")]
	public static CSteamID GetClanByIndex(int iClan) { }

	[Address(RVA = "0x5DAFD0", Offset = "0x5DA3D0", Length = "0x4E")]
	[Token(Token = "0x600007F")]
	public static int GetClanChatMemberCount(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DB020", Offset = "0x5DA420", Length = "0x124")]
	[Token(Token = "0x6000082")]
	public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) { }

	[Address(RVA = "0x5DB150", Offset = "0x5DA550", Length = "0x44")]
	[Token(Token = "0x6000059")]
	public static int GetClanCount() { }

	[Address(RVA = "0x5DB1A0", Offset = "0x5DA5A0", Length = "0x58")]
	[Token(Token = "0x600005B")]
	public static string GetClanName(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DB200", Offset = "0x5DA600", Length = "0x9A")]
	[Token(Token = "0x6000070")]
	public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer) { }

	[Address(RVA = "0x5DB2A0", Offset = "0x5DA6A0", Length = "0x4E")]
	[Token(Token = "0x600006F")]
	public static int GetClanOfficerCount(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DB2F0", Offset = "0x5DA6F0", Length = "0x8C")]
	[Token(Token = "0x600006E")]
	public static CSteamID GetClanOwner(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DB380", Offset = "0x5DA780", Length = "0x58")]
	[Token(Token = "0x600005C")]
	public static string GetClanTag(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DB430", Offset = "0x5DA830", Length = "0x8A")]
	[Token(Token = "0x600007A")]
	public static CSteamID GetCoplayFriend(int iCoplayFriend) { }

	[Address(RVA = "0x5DB3E0", Offset = "0x5DA7E0", Length = "0x44")]
	[Token(Token = "0x6000079")]
	public static int GetCoplayFriendCount() { }

	[Address(RVA = "0x5DB4C0", Offset = "0x5DA8C0", Length = "0x8C")]
	[Token(Token = "0x600008A")]
	public static SteamAPICall_t GetFollowerCount(CSteamID steamID) { }

	[Address(RVA = "0x5DB550", Offset = "0x5DA950", Length = "0x98")]
	[Token(Token = "0x600004B")]
	public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags) { }

	[Address(RVA = "0x5DB5F0", Offset = "0x5DA9F0", Length = "0x8A")]
	[Token(Token = "0x600007C")]
	public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DB680", Offset = "0x5DAA80", Length = "0x4E")]
	[Token(Token = "0x600007B")]
	public static int GetFriendCoplayTime(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DB720", Offset = "0x5DAB20", Length = "0x4C")]
	[Token(Token = "0x600004A")]
	public static int GetFriendCount(EFriendFlags iFriendFlags) { }

	[Address(RVA = "0x5DB6D0", Offset = "0x5DAAD0", Length = "0x4E")]
	[Token(Token = "0x600005F")]
	public static int GetFriendCountFromSource(CSteamID steamIDSource) { }

	[Address(RVA = "0x5DB770", Offset = "0x5DAB70", Length = "0x9A")]
	[Token(Token = "0x6000060")]
	public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend) { }

	[Address(RVA = "0x5DB810", Offset = "0x5DAC10", Length = "0x5D")]
	[Token(Token = "0x600004F")]
	public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) { }

	[Address(RVA = "0x5DB870", Offset = "0x5DAC70", Length = "0x117")]
	[Token(Token = "0x6000089")]
	public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType) { }

	[Address(RVA = "0x5DBA00", Offset = "0x5DAE00", Length = "0x58")]
	[Token(Token = "0x600004E")]
	public static string GetFriendPersonaName(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DB990", Offset = "0x5DAD90", Length = "0x66")]
	[Token(Token = "0x6000050")]
	public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName) { }

	[Address(RVA = "0x5DBA60", Offset = "0x5DAE60", Length = "0x4E")]
	[Token(Token = "0x600004D")]
	public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DBAB0", Offset = "0x5DAEB0", Length = "0x4E")]
	[Token(Token = "0x600004C")]
	public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DBBC0", Offset = "0x5DAFC0", Length = "0x134")]
	[Token(Token = "0x6000074")]
	public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey) { }

	[Address(RVA = "0x5DBB00", Offset = "0x5DAF00", Length = "0x66")]
	[Token(Token = "0x6000076")]
	public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey) { }

	[Address(RVA = "0x5DBB70", Offset = "0x5DAF70", Length = "0x4E")]
	[Token(Token = "0x6000075")]
	public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DBD50", Offset = "0x5DB150", Length = "0x44")]
	[Token(Token = "0x6000053")]
	public static int GetFriendsGroupCount() { }

	[Address(RVA = "0x5DBDA0", Offset = "0x5DB1A0", Length = "0x8A")]
	[Token(Token = "0x6000054")]
	public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG) { }

	[Address(RVA = "0x5DBE30", Offset = "0x5DB230", Length = "0x4E")]
	[Token(Token = "0x6000056")]
	public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID) { }

	[Address(RVA = "0x5DBE80", Offset = "0x5DB280", Length = "0x74")]
	[Token(Token = "0x6000057")]
	public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount) { }

	[Address(RVA = "0x5DBF00", Offset = "0x5DB300", Length = "0x58")]
	[Token(Token = "0x6000055")]
	public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID) { }

	[Address(RVA = "0x5DBD00", Offset = "0x5DB100", Length = "0x4E")]
	[Token(Token = "0x6000051")]
	public static int GetFriendSteamLevel(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DBF60", Offset = "0x5DB360", Length = "0x4E")]
	[Token(Token = "0x600006B")]
	public static int GetLargeFriendAvatar(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DBFB0", Offset = "0x5DB3B0", Length = "0x4E")]
	[Token(Token = "0x600006A")]
	public static int GetMediumFriendAvatar(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DC000", Offset = "0x5DB400", Length = "0x44")]
	[Token(Token = "0x600008F")]
	public static int GetNumChatsWithUnreadPriorityMessages() { }

	[Address(RVA = "0x5DC050", Offset = "0x5DB450", Length = "0x4E")]
	[Token(Token = "0x6000047")]
	public static string GetPersonaName() { }

	[Address(RVA = "0x5DC0A0", Offset = "0x5DB4A0", Length = "0x44")]
	[Token(Token = "0x6000049")]
	public static EPersonaState GetPersonaState() { }

	[Address(RVA = "0x5DC0F0", Offset = "0x5DB4F0", Length = "0x58")]
	[Token(Token = "0x6000052")]
	public static string GetPlayerNickname(CSteamID steamIDPlayer) { }

	[Address(RVA = "0x5DC150", Offset = "0x5DB550", Length = "0x7C")]
	[Token(Token = "0x6000095")]
	public static string GetProfileItemPropertyString(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	[Address(RVA = "0x5DC1D0", Offset = "0x5DB5D0", Length = "0x73")]
	[Token(Token = "0x6000096")]
	public static uint GetProfileItemPropertyUint(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	[Address(RVA = "0x5DC250", Offset = "0x5DB650", Length = "0x4E")]
	[Token(Token = "0x6000069")]
	public static int GetSmallFriendAvatar(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DC2A0", Offset = "0x5DB6A0", Length = "0x44")]
	[Token(Token = "0x6000071")]
	public static uint GetUserRestrictions() { }

	[Address(RVA = "0x5DC2F0", Offset = "0x5DB6F0", Length = "0x5C")]
	[Token(Token = "0x6000058")]
	public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags) { }

	[Address(RVA = "0x5DC350", Offset = "0x5DB750", Length = "0x125")]
	[Token(Token = "0x6000078")]
	public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString) { }

	[Address(RVA = "0x5DC480", Offset = "0x5DB880", Length = "0x5D")]
	[Token(Token = "0x6000083")]
	public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser) { }

	[Address(RVA = "0x5DC4E0", Offset = "0x5DB8E0", Length = "0x4E")]
	[Token(Token = "0x6000084")]
	public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat) { }

	[Address(RVA = "0x5DC530", Offset = "0x5DB930", Length = "0x4E")]
	[Token(Token = "0x600008E")]
	public static bool IsClanOfficialGameGroup(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DC580", Offset = "0x5DB980", Length = "0x4E")]
	[Token(Token = "0x600008D")]
	public static bool IsClanPublic(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DC5D0", Offset = "0x5DB9D0", Length = "0x8C")]
	[Token(Token = "0x600008B")]
	public static SteamAPICall_t IsFollowing(CSteamID steamID) { }

	[Address(RVA = "0x5DC660", Offset = "0x5DBA60", Length = "0x5D")]
	[Token(Token = "0x6000061")]
	public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource) { }

	[Address(RVA = "0x5DC6C0", Offset = "0x5DBAC0", Length = "0x8C")]
	[Token(Token = "0x600007D")]
	public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DC750", Offset = "0x5DBB50", Length = "0x4E")]
	[Token(Token = "0x600007E")]
	public static bool LeaveClanChatRoom(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DC7A0", Offset = "0x5DBBA0", Length = "0x4E")]
	[Token(Token = "0x6000085")]
	public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	[Address(RVA = "0x5DC7F0", Offset = "0x5DBBF0", Length = "0x115")]
	[Token(Token = "0x6000091")]
	public static bool RegisterProtocolInOverlayBrowser(string pchProtocol) { }

	[Address(RVA = "0x5DC910", Offset = "0x5DBD10", Length = "0x125")]
	[Token(Token = "0x6000088")]
	public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend) { }

	[Address(RVA = "0x5DCA40", Offset = "0x5DBE40", Length = "0x8C")]
	[Token(Token = "0x600006D")]
	public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan) { }

	[Address(RVA = "0x5DCAD0", Offset = "0x5DBED0", Length = "0x8C")]
	[Token(Token = "0x6000093")]
	public static SteamAPICall_t RequestEquippedProfileItems(CSteamID steamID) { }

	[Address(RVA = "0x5DCB60", Offset = "0x5DBF60", Length = "0x4E")]
	[Token(Token = "0x6000077")]
	public static void RequestFriendRichPresence(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5DCBB0", Offset = "0x5DBFB0", Length = "0x5E")]
	[Token(Token = "0x600006C")]
	public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly) { }

	[Address(RVA = "0x5DCC10", Offset = "0x5DC010", Length = "0x125")]
	[Token(Token = "0x6000081")]
	public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText) { }

	[Address(RVA = "0x5DCD40", Offset = "0x5DC140", Length = "0x5E")]
	[Token(Token = "0x6000062")]
	public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking) { }

	[Address(RVA = "0x5DCDA0", Offset = "0x5DC1A0", Length = "0x4E")]
	[Token(Token = "0x6000087")]
	public static bool SetListenForFriendsMessages(bool bInterceptEnabled) { }

	[Address(RVA = "0x5DCDF0", Offset = "0x5DC1F0", Length = "0x148")]
	[Token(Token = "0x6000048")]
	public static SteamAPICall_t SetPersonaName(string pchPersonaName) { }

	[Address(RVA = "0x5DCF40", Offset = "0x5DC340", Length = "0x4E")]
	[Token(Token = "0x6000067")]
	public static void SetPlayedWith(CSteamID steamIDUserPlayedWith) { }

	[Address(RVA = "0x5DCF90", Offset = "0x5DC390", Length = "0x1AA")]
	[Token(Token = "0x6000072")]
	public static bool SetRichPresence(string pchKey, string pchValue) { }

}

