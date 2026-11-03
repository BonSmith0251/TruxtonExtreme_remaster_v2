namespace Steamworks;

[Token(Token = "0x2000016")]
public static class SteamMatchmaking
{

	[Address(RVA = "0x5F4970", Offset = "0x5F3D70", Length = "0x96")]
	[Token(Token = "0x60002AB")]
	public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	[Address(RVA = "0x5F4A10", Offset = "0x5F3E10", Length = "0x4E")]
	[Token(Token = "0x60002B4")]
	public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F4A60", Offset = "0x5F3E60", Length = "0x4C")]
	[Token(Token = "0x60002B2")]
	public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter) { }

	[Address(RVA = "0x5F4AB0", Offset = "0x5F3EB0", Length = "0x4C")]
	[Token(Token = "0x60002B1")]
	public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) { }

	[Address(RVA = "0x5F4B00", Offset = "0x5F3F00", Length = "0x111")]
	[Token(Token = "0x60002B0")]
	public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo) { }

	[Address(RVA = "0x5F4C20", Offset = "0x5F4020", Length = "0x129")]
	[Token(Token = "0x60002AF")]
	public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) { }

	[Address(RVA = "0x5F4D50", Offset = "0x5F4150", Length = "0x4C")]
	[Token(Token = "0x60002B3")]
	public static void AddRequestLobbyListResultCountFilter(int cMaxResults) { }

	[Address(RVA = "0x5F4DA0", Offset = "0x5F41A0", Length = "0x1BC")]
	[Token(Token = "0x60002AE")]
	public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType) { }

	[Address(RVA = "0x5F4F60", Offset = "0x5F4360", Length = "0x98")]
	[Token(Token = "0x60002B6")]
	public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers) { }

	[Address(RVA = "0x5F5000", Offset = "0x5F4400", Length = "0x125")]
	[Token(Token = "0x60002C0")]
	public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey) { }

	[Address(RVA = "0x5F5180", Offset = "0x5F4580", Length = "0xAB")]
	[Token(Token = "0x60002AA")]
	public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	[Address(RVA = "0x5F5130", Offset = "0x5F4530", Length = "0x44")]
	[Token(Token = "0x60002A9")]
	public static int GetFavoriteGameCount() { }

	[Address(RVA = "0x5F5230", Offset = "0x5F4630", Length = "0x8A")]
	[Token(Token = "0x60002B5")]
	public static CSteamID GetLobbyByIndex(int iLobby) { }

	[Address(RVA = "0x5F52C0", Offset = "0x5F46C0", Length = "0x97")]
	[Token(Token = "0x60002C4")]
	public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, Byte[] pvData, int cubData, out EChatEntryType peChatEntryType) { }

	[Address(RVA = "0x5F5530", Offset = "0x5F4930", Length = "0x134")]
	[Token(Token = "0x60002BC")]
	public static string GetLobbyData(CSteamID steamIDLobby, string pchKey) { }

	[Address(RVA = "0x5F5360", Offset = "0x5F4760", Length = "0x17C")]
	[Token(Token = "0x60002BF")]
	public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize) { }

	[Address(RVA = "0x5F54E0", Offset = "0x5F48E0", Length = "0x4E")]
	[Token(Token = "0x60002BE")]
	public static int GetLobbyDataCount(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F5670", Offset = "0x5F4A70", Length = "0x86")]
	[Token(Token = "0x60002C7")]
	public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) { }

	[Address(RVA = "0x5F5700", Offset = "0x5F4B00", Length = "0x9A")]
	[Token(Token = "0x60002BB")]
	public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember) { }

	[Address(RVA = "0x5F57A0", Offset = "0x5F4BA0", Length = "0x14D")]
	[Token(Token = "0x60002C1")]
	public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey) { }

	[Address(RVA = "0x5F58F0", Offset = "0x5F4CF0", Length = "0x4E")]
	[Token(Token = "0x60002C9")]
	public static int GetLobbyMemberLimit(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F5940", Offset = "0x5F4D40", Length = "0x8C")]
	[Token(Token = "0x60002CC")]
	public static CSteamID GetLobbyOwner(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F59D0", Offset = "0x5F4DD0", Length = "0x4E")]
	[Token(Token = "0x60002BA")]
	public static int GetNumLobbyMembers(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F5A20", Offset = "0x5F4E20", Length = "0x5D")]
	[Token(Token = "0x60002B9")]
	public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee) { }

	[Address(RVA = "0x5F5A80", Offset = "0x5F4E80", Length = "0x8C")]
	[Token(Token = "0x60002B7")]
	public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F5B10", Offset = "0x5F4F10", Length = "0x4E")]
	[Token(Token = "0x60002B8")]
	public static void LeaveLobby(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F5B60", Offset = "0x5F4F60", Length = "0x8E")]
	[Token(Token = "0x60002AC")]
	public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	[Address(RVA = "0x5F5BF0", Offset = "0x5F4FF0", Length = "0x4E")]
	[Token(Token = "0x60002C5")]
	public static bool RequestLobbyData(CSteamID steamIDLobby) { }

	[Address(RVA = "0x5F5C40", Offset = "0x5F5040", Length = "0x85")]
	[Token(Token = "0x60002AD")]
	public static SteamAPICall_t RequestLobbyList() { }

	[Address(RVA = "0x5F5CD0", Offset = "0x5F50D0", Length = "0x74")]
	[Token(Token = "0x60002C3")]
	public static bool SendLobbyChatMsg(CSteamID steamIDLobby, Byte[] pvMsgBody, int cubMsgBody) { }

	[Address(RVA = "0x5F5D50", Offset = "0x5F5150", Length = "0x5D")]
	[Token(Token = "0x60002CE")]
	public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) { }

	[Address(RVA = "0x5F5DB0", Offset = "0x5F51B0", Length = "0x1C6")]
	[Token(Token = "0x60002BD")]
	public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	[Address(RVA = "0x5F5F80", Offset = "0x5F5380", Length = "0x87")]
	[Token(Token = "0x60002C6")]
	public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) { }

	[Address(RVA = "0x5F6010", Offset = "0x5F5410", Length = "0x5E")]
	[Token(Token = "0x60002CB")]
	public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable) { }

	[Address(RVA = "0x5F6070", Offset = "0x5F5470", Length = "0x1BC")]
	[Token(Token = "0x60002C2")]
	public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	[Address(RVA = "0x5F6230", Offset = "0x5F5630", Length = "0x5C")]
	[Token(Token = "0x60002C8")]
	public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers) { }

	[Address(RVA = "0x5F6290", Offset = "0x5F5690", Length = "0x5D")]
	[Token(Token = "0x60002CD")]
	public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner) { }

	[Address(RVA = "0x5F62F0", Offset = "0x5F56F0", Length = "0x5C")]
	[Token(Token = "0x60002CA")]
	public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType) { }

}

