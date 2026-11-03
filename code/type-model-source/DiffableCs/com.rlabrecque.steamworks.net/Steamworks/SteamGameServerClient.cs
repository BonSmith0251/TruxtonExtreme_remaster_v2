namespace Steamworks;

[Token(Token = "0x2000008")]
public static class SteamGameServerClient
{

	[Address(RVA = "0x5DDAA0", Offset = "0x5DCEA0", Length = "0x4B")]
	[Token(Token = "0x60000C1")]
	public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x5DDAF0", Offset = "0x5DCEF0", Length = "0x43")]
	[Token(Token = "0x60000D6")]
	public static bool BShutdownIfAllPipesClosed() { }

	[Address(RVA = "0x5DDB40", Offset = "0x5DCF40", Length = "0x54")]
	[Token(Token = "0x60000C2")]
	public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x5DDBA0", Offset = "0x5DCFA0", Length = "0x64")]
	[Token(Token = "0x60000C3")]
	public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	[Address(RVA = "0x5DDC10", Offset = "0x5DD010", Length = "0x4C")]
	[Token(Token = "0x60000C0")]
	public static HSteamPipe CreateSteamPipe() { }

	[Address(RVA = "0x5DDC60", Offset = "0x5DD060", Length = "0x43")]
	[Token(Token = "0x60000D4")]
	public static uint GetIPCCallCount() { }

	[Address(RVA = "0x5DDCB0", Offset = "0x5DD0B0", Length = "0x13F")]
	[Token(Token = "0x60000CF")]
	public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DDDF0", Offset = "0x5DD1F0", Length = "0x13F")]
	[Token(Token = "0x60000D8")]
	public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DDF30", Offset = "0x5DD330", Length = "0x13F")]
	[Token(Token = "0x60000C8")]
	public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE070", Offset = "0x5DD470", Length = "0x13F")]
	[Token(Token = "0x60000D3")]
	public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE2F0", Offset = "0x5DD6F0", Length = "0x13F")]
	[Token(Token = "0x60000C6")]
	public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE1B0", Offset = "0x5DD5B0", Length = "0x13F")]
	[Token(Token = "0x60000CE")]
	public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE430", Offset = "0x5DD830", Length = "0x13F")]
	[Token(Token = "0x60000CC")]
	public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE570", Offset = "0x5DD970", Length = "0x13F")]
	[Token(Token = "0x60000DC")]
	public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE6B0", Offset = "0x5DDAB0", Length = "0x13F")]
	[Token(Token = "0x60000D7")]
	public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE7F0", Offset = "0x5DDBF0", Length = "0x13F")]
	[Token(Token = "0x60000E0")]
	public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DE930", Offset = "0x5DDD30", Length = "0x13F")]
	[Token(Token = "0x60000DD")]
	public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DEBB0", Offset = "0x5DDFB0", Length = "0x13F")]
	[Token(Token = "0x60000CA")]
	public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DEA70", Offset = "0x5DDE70", Length = "0x13F")]
	[Token(Token = "0x60000CB")]
	public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DEE30", Offset = "0x5DE230", Length = "0x13F")]
	[Token(Token = "0x60000DA")]
	public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DECF0", Offset = "0x5DE0F0", Length = "0x13F")]
	[Token(Token = "0x60000DB")]
	public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DEF70", Offset = "0x5DE370", Length = "0x13F")]
	[Token(Token = "0x60000D0")]
	public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF0B0", Offset = "0x5DE4B0", Length = "0x13F")]
	[Token(Token = "0x60000DF")]
	public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF1F0", Offset = "0x5DE5F0", Length = "0x13F")]
	[Token(Token = "0x60000E1")]
	public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF330", Offset = "0x5DE730", Length = "0x13F")]
	[Token(Token = "0x60000E2")]
	public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF470", Offset = "0x5DE870", Length = "0x13F")]
	[Token(Token = "0x60000D1")]
	public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF5B0", Offset = "0x5DE9B0", Length = "0x13F")]
	[Token(Token = "0x60000D2")]
	public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF6F0", Offset = "0x5DEAF0", Length = "0x13F")]
	[Token(Token = "0x60000D9")]
	public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF970", Offset = "0x5DED70", Length = "0x13F")]
	[Token(Token = "0x60000C5")]
	public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DF830", Offset = "0x5DEC30", Length = "0x13F")]
	[Token(Token = "0x60000CD")]
	public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DFAB0", Offset = "0x5DEEB0", Length = "0x127")]
	[Token(Token = "0x60000C9")]
	public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DFBE0", Offset = "0x5DEFE0", Length = "0x13F")]
	[Token(Token = "0x60000DE")]
	public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DFD20", Offset = "0x5DF120", Length = "0x59")]
	[Token(Token = "0x60000C4")]
	public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) { }

	[Address(RVA = "0x5DFD80", Offset = "0x5DF180", Length = "0x5D")]
	[Token(Token = "0x60000C7")]
	public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) { }

	[Address(RVA = "0x5DFDE0", Offset = "0x5DF1E0", Length = "0x4D")]
	[Token(Token = "0x60000D5")]
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

}

