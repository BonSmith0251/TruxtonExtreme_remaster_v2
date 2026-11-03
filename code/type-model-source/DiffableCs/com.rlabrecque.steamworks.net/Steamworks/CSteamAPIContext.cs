namespace Steamworks;

[Token(Token = "0x20001B3")]
internal static class CSteamAPIContext
{
	[Token(Token = "0x4000A88")]
	private static IntPtr m_pSteamClient; //Field offset: 0x0
	[Token(Token = "0x4000A89")]
	private static IntPtr m_pSteamUser; //Field offset: 0x8
	[Token(Token = "0x4000A8A")]
	private static IntPtr m_pSteamFriends; //Field offset: 0x10
	[Token(Token = "0x4000A8B")]
	private static IntPtr m_pSteamUtils; //Field offset: 0x18
	[Token(Token = "0x4000A8C")]
	private static IntPtr m_pSteamMatchmaking; //Field offset: 0x20
	[Token(Token = "0x4000A8D")]
	private static IntPtr m_pSteamUserStats; //Field offset: 0x28
	[Token(Token = "0x4000A8E")]
	private static IntPtr m_pSteamApps; //Field offset: 0x30
	[Token(Token = "0x4000A8F")]
	private static IntPtr m_pSteamMatchmakingServers; //Field offset: 0x38
	[Token(Token = "0x4000A90")]
	private static IntPtr m_pSteamNetworking; //Field offset: 0x40
	[Token(Token = "0x4000A91")]
	private static IntPtr m_pSteamRemoteStorage; //Field offset: 0x48
	[Token(Token = "0x4000A92")]
	private static IntPtr m_pSteamScreenshots; //Field offset: 0x50
	[Token(Token = "0x4000A93")]
	private static IntPtr m_pSteamGameSearch; //Field offset: 0x58
	[Token(Token = "0x4000A94")]
	private static IntPtr m_pSteamHTTP; //Field offset: 0x60
	[Token(Token = "0x4000A95")]
	private static IntPtr m_pController; //Field offset: 0x68
	[Token(Token = "0x4000A96")]
	private static IntPtr m_pSteamUGC; //Field offset: 0x70
	[Token(Token = "0x4000A97")]
	private static IntPtr m_pSteamMusic; //Field offset: 0x78
	[Token(Token = "0x4000A98")]
	private static IntPtr m_pSteamMusicRemote; //Field offset: 0x80
	[Token(Token = "0x4000A99")]
	private static IntPtr m_pSteamHTMLSurface; //Field offset: 0x88
	[Token(Token = "0x4000A9A")]
	private static IntPtr m_pSteamInventory; //Field offset: 0x90
	[Token(Token = "0x4000A9B")]
	private static IntPtr m_pSteamVideo; //Field offset: 0x98
	[Token(Token = "0x4000A9C")]
	private static IntPtr m_pSteamParentalSettings; //Field offset: 0xA0
	[Token(Token = "0x4000A9D")]
	private static IntPtr m_pSteamInput; //Field offset: 0xA8
	[Token(Token = "0x4000A9E")]
	private static IntPtr m_pSteamParties; //Field offset: 0xB0
	[Token(Token = "0x4000A9F")]
	private static IntPtr m_pSteamRemotePlay; //Field offset: 0xB8
	[Token(Token = "0x4000AA0")]
	private static IntPtr m_pSteamNetworkingUtils; //Field offset: 0xC0
	[Token(Token = "0x4000AA1")]
	private static IntPtr m_pSteamNetworkingSockets; //Field offset: 0xC8
	[Token(Token = "0x4000AA2")]
	private static IntPtr m_pSteamNetworkingMessages; //Field offset: 0xD0
	[Token(Token = "0x4000AA3")]
	private static IntPtr m_pSteamTimeline; //Field offset: 0xD8

	[Address(RVA = "0x604B60", Offset = "0x603F60", Length = "0x254")]
	[Token(Token = "0x6000993")]
	internal static void Clear() { }

	[Address(RVA = "0x604DC0", Offset = "0x6041C0", Length = "0x37")]
	[Token(Token = "0x600099B")]
	internal static IntPtr GetSteamApps() { }

	[Address(RVA = "0x604E00", Offset = "0x604200", Length = "0x36")]
	[Token(Token = "0x6000995")]
	internal static IntPtr GetSteamClient() { }

	[Address(RVA = "0x604E40", Offset = "0x604240", Length = "0x37")]
	[Token(Token = "0x60009A2")]
	internal static IntPtr GetSteamController() { }

	[Address(RVA = "0x604E80", Offset = "0x604280", Length = "0x37")]
	[Token(Token = "0x6000997")]
	internal static IntPtr GetSteamFriends() { }

	[Address(RVA = "0x604EC0", Offset = "0x6042C0", Length = "0x37")]
	[Token(Token = "0x60009A0")]
	internal static IntPtr GetSteamGameSearch() { }

	[Address(RVA = "0x604F00", Offset = "0x604300", Length = "0x3A")]
	[Token(Token = "0x60009A6")]
	internal static IntPtr GetSteamHTMLSurface() { }

	[Address(RVA = "0x604F40", Offset = "0x604340", Length = "0x37")]
	[Token(Token = "0x60009A1")]
	internal static IntPtr GetSteamHTTP() { }

	[Address(RVA = "0x604F80", Offset = "0x604380", Length = "0x3A")]
	[Token(Token = "0x60009AA")]
	internal static IntPtr GetSteamInput() { }

	[Address(RVA = "0x604FC0", Offset = "0x6043C0", Length = "0x3A")]
	[Token(Token = "0x60009A7")]
	internal static IntPtr GetSteamInventory() { }

	[Address(RVA = "0x605040", Offset = "0x604440", Length = "0x37")]
	[Token(Token = "0x6000999")]
	internal static IntPtr GetSteamMatchmaking() { }

	[Address(RVA = "0x605000", Offset = "0x604400", Length = "0x37")]
	[Token(Token = "0x600099C")]
	internal static IntPtr GetSteamMatchmakingServers() { }

	[Address(RVA = "0x6050C0", Offset = "0x6044C0", Length = "0x37")]
	[Token(Token = "0x60009A4")]
	internal static IntPtr GetSteamMusic() { }

	[Address(RVA = "0x605080", Offset = "0x604480", Length = "0x3A")]
	[Token(Token = "0x60009A5")]
	internal static IntPtr GetSteamMusicRemote() { }

	[Address(RVA = "0x6051C0", Offset = "0x6045C0", Length = "0x37")]
	[Token(Token = "0x600099D")]
	internal static IntPtr GetSteamNetworking() { }

	[Address(RVA = "0x605100", Offset = "0x604500", Length = "0x3A")]
	[Token(Token = "0x60009AF")]
	internal static IntPtr GetSteamNetworkingMessages() { }

	[Address(RVA = "0x605140", Offset = "0x604540", Length = "0x3A")]
	[Token(Token = "0x60009AE")]
	internal static IntPtr GetSteamNetworkingSockets() { }

	[Address(RVA = "0x605180", Offset = "0x604580", Length = "0x3A")]
	[Token(Token = "0x60009AD")]
	internal static IntPtr GetSteamNetworkingUtils() { }

	[Address(RVA = "0x605200", Offset = "0x604600", Length = "0x3A")]
	[Token(Token = "0x60009A9")]
	internal static IntPtr GetSteamParentalSettings() { }

	[Address(RVA = "0x605240", Offset = "0x604640", Length = "0x3A")]
	[Token(Token = "0x60009AB")]
	internal static IntPtr GetSteamParties() { }

	[Address(RVA = "0x605280", Offset = "0x604680", Length = "0x3A")]
	[Token(Token = "0x60009AC")]
	internal static IntPtr GetSteamRemotePlay() { }

	[Address(RVA = "0x6052C0", Offset = "0x6046C0", Length = "0x37")]
	[Token(Token = "0x600099E")]
	internal static IntPtr GetSteamRemoteStorage() { }

	[Address(RVA = "0x605300", Offset = "0x604700", Length = "0x37")]
	[Token(Token = "0x600099F")]
	internal static IntPtr GetSteamScreenshots() { }

	[Address(RVA = "0x605340", Offset = "0x604740", Length = "0x3A")]
	[Token(Token = "0x60009B0")]
	internal static IntPtr GetSteamTimeline() { }

	[Address(RVA = "0x605380", Offset = "0x604780", Length = "0x37")]
	[Token(Token = "0x60009A3")]
	internal static IntPtr GetSteamUGC() { }

	[Address(RVA = "0x605400", Offset = "0x604800", Length = "0x37")]
	[Token(Token = "0x6000996")]
	internal static IntPtr GetSteamUser() { }

	[Address(RVA = "0x6053C0", Offset = "0x6047C0", Length = "0x37")]
	[Token(Token = "0x600099A")]
	internal static IntPtr GetSteamUserStats() { }

	[Address(RVA = "0x605440", Offset = "0x604840", Length = "0x37")]
	[Token(Token = "0x6000998")]
	internal static IntPtr GetSteamUtils() { }

	[Address(RVA = "0x605480", Offset = "0x604880", Length = "0x3A")]
	[Token(Token = "0x60009A8")]
	internal static IntPtr GetSteamVideo() { }

	[Address(RVA = "0x6054C0", Offset = "0x6048C0", Length = "0xBE3")]
	[Token(Token = "0x6000994")]
	internal static bool Init() { }

}

