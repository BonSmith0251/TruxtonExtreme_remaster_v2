namespace Steamworks;

[Token(Token = "0x2000007")]
public static class SteamGameServer
{

	[Address(RVA = "0x5EC600", Offset = "0x5EBA00", Length = "0x8C")]
	[Token(Token = "0x60000BA")]
	public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan) { }

	[Address(RVA = "0x5EC870", Offset = "0x5EBC70", Length = "0x73")]
	[Token(Token = "0x60000B0")]
	public static EBeginAuthSessionResult BeginAuthSession(Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	[Address(RVA = "0x5EC690", Offset = "0x5EBA90", Length = "0x44")]
	[Token(Token = "0x600009E")]
	public static bool BLoggedOn() { }

	[Address(RVA = "0x5EC6E0", Offset = "0x5EBAE0", Length = "0x44")]
	[Token(Token = "0x600009F")]
	public static bool BSecure() { }

	[Address(RVA = "0x5EC730", Offset = "0x5EBB30", Length = "0x13D")]
	[Token(Token = "0x60000BF")]
	public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore) { }

	[Address(RVA = "0x5EC8F0", Offset = "0x5EBCF0", Length = "0x4C")]
	[Token(Token = "0x60000B2")]
	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	[Address(RVA = "0x5EC940", Offset = "0x5EBD40", Length = "0x44")]
	[Token(Token = "0x60000A9")]
	public static void ClearAllKeyValues() { }

	[Address(RVA = "0x5EC990", Offset = "0x5EBD90", Length = "0x8C")]
	[Token(Token = "0x60000BB")]
	public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer) { }

	[Address(RVA = "0x5ECA20", Offset = "0x5EBE20", Length = "0x85")]
	[Token(Token = "0x60000BD")]
	public static CSteamID CreateUnauthenticatedUserConnection() { }

	[Address(RVA = "0x5ECAB0", Offset = "0x5EBEB0", Length = "0x4E")]
	[Token(Token = "0x60000B1")]
	public static void EndAuthSession(CSteamID steamID) { }

	[Address(RVA = "0x5ECB00", Offset = "0x5EBF00", Length = "0xC0")]
	[Token(Token = "0x60000AF")]
	public static HAuthTicket GetAuthSessionTicket(Byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSnid) { }

	[Address(RVA = "0x5ECBC0", Offset = "0x5EBFC0", Length = "0x44")]
	[Token(Token = "0x60000B5")]
	public static void GetGameplayStats() { }

	[Address(RVA = "0x5ECC10", Offset = "0x5EC010", Length = "0x85")]
	[Token(Token = "0x60000B9")]
	public static int GetNextOutgoingPacket(Byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) { }

	[Address(RVA = "0x5ECCA0", Offset = "0x5EC0A0", Length = "0x60")]
	[Token(Token = "0x60000B7")]
	public static SteamIPAddress_t GetPublicIP() { }

	[Address(RVA = "0x5ECD00", Offset = "0x5EC100", Length = "0x85")]
	[Token(Token = "0x60000B6")]
	public static SteamAPICall_t GetServerReputation() { }

	[Address(RVA = "0x5ECD90", Offset = "0x5EC190", Length = "0x85")]
	[Token(Token = "0x60000A0")]
	public static CSteamID GetSteamID() { }

	[Address(RVA = "0x5ECE20", Offset = "0x5EC220", Length = "0x86")]
	[Token(Token = "0x60000B8")]
	public static bool HandleIncomingPacket(Byte[] pData, int cbData, uint srcIP, ushort srcPort) { }

	[Address(RVA = "0x5ECEB0", Offset = "0x5EC2B0", Length = "0x44")]
	[Token(Token = "0x600009D")]
	public static void LogOff() { }

	[Address(RVA = "0x5ECF50", Offset = "0x5EC350", Length = "0x102")]
	[Token(Token = "0x600009B")]
	public static void LogOn(string pszToken) { }

	[Address(RVA = "0x5ECF00", Offset = "0x5EC300", Length = "0x44")]
	[Token(Token = "0x600009C")]
	public static void LogOnAnonymous() { }

	[Address(RVA = "0x5ED060", Offset = "0x5EC460", Length = "0x5D")]
	[Token(Token = "0x60000B4")]
	public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup) { }

	[Address(RVA = "0x5ED0C0", Offset = "0x5EC4C0", Length = "0x84")]
	[Token(Token = "0x60000BC")]
	public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, Byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) { }

	[Address(RVA = "0x5ED150", Offset = "0x5EC550", Length = "0x4E")]
	[Token(Token = "0x60000BE")]
	public static void SendUserDisconnect_DEPRECATED(CSteamID steamIDUser) { }

	[Address(RVA = "0x5ED1A0", Offset = "0x5EC5A0", Length = "0x4E")]
	[Token(Token = "0x60000AE")]
	public static void SetAdvertiseServerActive(bool bActive) { }

	[Address(RVA = "0x5ED1F0", Offset = "0x5EC5F0", Length = "0x4C")]
	[Token(Token = "0x60000A3")]
	public static void SetBotPlayerCount(int cBotplayers) { }

	[Address(RVA = "0x5ED240", Offset = "0x5EC640", Length = "0x4E")]
	[Token(Token = "0x600009A")]
	public static void SetDedicatedServer(bool bDedicated) { }

	[Address(RVA = "0x5ED290", Offset = "0x5EC690", Length = "0x102")]
	[Token(Token = "0x60000AC")]
	public static void SetGameData(string pchGameData) { }

	[Address(RVA = "0x5ED3A0", Offset = "0x5EC7A0", Length = "0x102")]
	[Token(Token = "0x6000098")]
	public static void SetGameDescription(string pszGameDescription) { }

	[Address(RVA = "0x5ED4B0", Offset = "0x5EC8B0", Length = "0x102")]
	[Token(Token = "0x60000AB")]
	public static void SetGameTags(string pchGameTags) { }

	[Address(RVA = "0x5ED5C0", Offset = "0x5EC9C0", Length = "0x185")]
	[Token(Token = "0x60000AA")]
	public static void SetKeyValue(string pKey, string pValue) { }

	[Address(RVA = "0x5ED750", Offset = "0x5ECB50", Length = "0x102")]
	[Token(Token = "0x60000A5")]
	public static void SetMapName(string pszMapName) { }

	[Address(RVA = "0x5ED860", Offset = "0x5ECC60", Length = "0x4C")]
	[Token(Token = "0x60000A2")]
	public static void SetMaxPlayerCount(int cPlayersMax) { }

	[Address(RVA = "0x5ED8B0", Offset = "0x5ECCB0", Length = "0x102")]
	[Token(Token = "0x6000099")]
	public static void SetModDir(string pszModDir) { }

	[Address(RVA = "0x5ED9C0", Offset = "0x5ECDC0", Length = "0x4E")]
	[Token(Token = "0x60000A6")]
	public static void SetPasswordProtected(bool bPasswordProtected) { }

	[Address(RVA = "0x5EDA10", Offset = "0x5ECE10", Length = "0x102")]
	[Token(Token = "0x6000097")]
	public static void SetProduct(string pszProduct) { }

	[Address(RVA = "0x5EDB20", Offset = "0x5ECF20", Length = "0x102")]
	[Token(Token = "0x60000AD")]
	public static void SetRegion(string pszRegion) { }

	[Address(RVA = "0x5EDC30", Offset = "0x5ED030", Length = "0x102")]
	[Token(Token = "0x60000A4")]
	public static void SetServerName(string pszServerName) { }

	[Address(RVA = "0x5EDD40", Offset = "0x5ED140", Length = "0x4E")]
	[Token(Token = "0x60000A7")]
	public static void SetSpectatorPort(ushort unSpectatorPort) { }

	[Address(RVA = "0x5EDD90", Offset = "0x5ED190", Length = "0x102")]
	[Token(Token = "0x60000A8")]
	public static void SetSpectatorServerName(string pszSpectatorServerName) { }

	[Address(RVA = "0x5EDEA0", Offset = "0x5ED2A0", Length = "0x5C")]
	[Token(Token = "0x60000B3")]
	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

	[Address(RVA = "0x5EDF00", Offset = "0x5ED300", Length = "0x44")]
	[Token(Token = "0x60000A1")]
	public static bool WasRestartRequested() { }

}

