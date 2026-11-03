namespace Steamworks;

[Token(Token = "0x2000005")]
public static class SteamClient
{

	[Address(RVA = "0x5D82F0", Offset = "0x5D76F0", Length = "0x4B")]
	[Token(Token = "0x6000025")]
	public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x5D8340", Offset = "0x5D7740", Length = "0x43")]
	[Token(Token = "0x600003A")]
	public static bool BShutdownIfAllPipesClosed() { }

	[Address(RVA = "0x5D8390", Offset = "0x5D7790", Length = "0x54")]
	[Token(Token = "0x6000026")]
	public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) { }

	[Address(RVA = "0x5D83F0", Offset = "0x5D77F0", Length = "0x64")]
	[Token(Token = "0x6000027")]
	public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	[Address(RVA = "0x5D8460", Offset = "0x5D7860", Length = "0x4C")]
	[Token(Token = "0x6000024")]
	public static HSteamPipe CreateSteamPipe() { }

	[Address(RVA = "0x5D84B0", Offset = "0x5D78B0", Length = "0x43")]
	[Token(Token = "0x6000038")]
	public static uint GetIPCCallCount() { }

	[Address(RVA = "0x5D8500", Offset = "0x5D7900", Length = "0x13F")]
	[Token(Token = "0x6000033")]
	public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D8640", Offset = "0x5D7A40", Length = "0x13F")]
	[Token(Token = "0x600003C")]
	public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D8780", Offset = "0x5D7B80", Length = "0x13F")]
	[Token(Token = "0x600002C")]
	public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D88C0", Offset = "0x5D7CC0", Length = "0x13F")]
	[Token(Token = "0x6000037")]
	public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D8B40", Offset = "0x5D7F40", Length = "0x13F")]
	[Token(Token = "0x600002A")]
	public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D8A00", Offset = "0x5D7E00", Length = "0x13F")]
	[Token(Token = "0x6000032")]
	public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D8C80", Offset = "0x5D8080", Length = "0x13F")]
	[Token(Token = "0x6000030")]
	public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D8DC0", Offset = "0x5D81C0", Length = "0x13F")]
	[Token(Token = "0x6000040")]
	public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D8F00", Offset = "0x5D8300", Length = "0x13F")]
	[Token(Token = "0x600003B")]
	public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9040", Offset = "0x5D8440", Length = "0x13F")]
	[Token(Token = "0x6000044")]
	public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9180", Offset = "0x5D8580", Length = "0x13F")]
	[Token(Token = "0x6000041")]
	public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9400", Offset = "0x5D8800", Length = "0x13F")]
	[Token(Token = "0x600002E")]
	public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D92C0", Offset = "0x5D86C0", Length = "0x13F")]
	[Token(Token = "0x600002F")]
	public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9680", Offset = "0x5D8A80", Length = "0x13F")]
	[Token(Token = "0x600003E")]
	public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9540", Offset = "0x5D8940", Length = "0x13F")]
	[Token(Token = "0x600003F")]
	public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D97C0", Offset = "0x5D8BC0", Length = "0x13F")]
	[Token(Token = "0x6000034")]
	public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9900", Offset = "0x5D8D00", Length = "0x13F")]
	[Token(Token = "0x6000043")]
	public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9A40", Offset = "0x5D8E40", Length = "0x13F")]
	[Token(Token = "0x6000045")]
	public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9B80", Offset = "0x5D8F80", Length = "0x13F")]
	[Token(Token = "0x6000046")]
	public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9CC0", Offset = "0x5D90C0", Length = "0x13F")]
	[Token(Token = "0x6000035")]
	public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9E00", Offset = "0x5D9200", Length = "0x13F")]
	[Token(Token = "0x6000036")]
	public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5D9F40", Offset = "0x5D9340", Length = "0x13F")]
	[Token(Token = "0x600003D")]
	public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DA1C0", Offset = "0x5D95C0", Length = "0x13F")]
	[Token(Token = "0x6000029")]
	public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DA080", Offset = "0x5D9480", Length = "0x13F")]
	[Token(Token = "0x6000031")]
	public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DA300", Offset = "0x5D9700", Length = "0x127")]
	[Token(Token = "0x600002D")]
	public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DA430", Offset = "0x5D9830", Length = "0x13F")]
	[Token(Token = "0x6000042")]
	public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	[Address(RVA = "0x5DA570", Offset = "0x5D9970", Length = "0x59")]
	[Token(Token = "0x6000028")]
	public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) { }

	[Address(RVA = "0x5DA5D0", Offset = "0x5D99D0", Length = "0x5D")]
	[Token(Token = "0x600002B")]
	public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) { }

	[Address(RVA = "0x5DA630", Offset = "0x5D9A30", Length = "0x4D")]
	[Token(Token = "0x6000039")]
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

}

