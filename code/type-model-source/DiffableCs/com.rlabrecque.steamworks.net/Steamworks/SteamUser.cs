namespace Steamworks;

[Token(Token = "0x2000026")]
public static class SteamUser
{

	[Address(RVA = "0x641480", Offset = "0x640880", Length = "0xDA")]
	[Token(Token = "0x6000451")]
	public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) { }

	[Address(RVA = "0x641A40", Offset = "0x640E40", Length = "0xE2")]
	[Token(Token = "0x600044C")]
	public static EBeginAuthSessionResult BeginAuthSession(Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	[Address(RVA = "0x641560", Offset = "0x640960", Length = "0xAF")]
	[Token(Token = "0x6000450")]
	public static bool BIsBehindNAT() { }

	[Address(RVA = "0x641610", Offset = "0x640A10", Length = "0xAF")]
	[Token(Token = "0x6000459")]
	public static bool BIsPhoneIdentifying() { }

	[Address(RVA = "0x6416C0", Offset = "0x640AC0", Length = "0xAF")]
	[Token(Token = "0x600045A")]
	public static bool BIsPhoneRequiringVerification() { }

	[Address(RVA = "0x641770", Offset = "0x640B70", Length = "0xAF")]
	[Token(Token = "0x6000457")]
	public static bool BIsPhoneVerified() { }

	[Address(RVA = "0x641820", Offset = "0x640C20", Length = "0xAF")]
	[Token(Token = "0x6000458")]
	public static bool BIsTwoFactorEnabled() { }

	[Address(RVA = "0x6418D0", Offset = "0x640CD0", Length = "0xAF")]
	[Token(Token = "0x600043E")]
	public static bool BLoggedOn() { }

	[Address(RVA = "0x641980", Offset = "0x640D80", Length = "0xBC")]
	[Token(Token = "0x600045D")]
	public static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState) { }

	[Address(RVA = "0x641B30", Offset = "0x640F30", Length = "0xB7")]
	[Token(Token = "0x600044E")]
	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	[Address(RVA = "0x641BF0", Offset = "0x640FF0", Length = "0x11A")]
	[Token(Token = "0x6000448")]
	public static EVoiceResult DecompressVoice(Byte[] pCompressed, uint cbCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) { }

	[Address(RVA = "0x641D10", Offset = "0x641110", Length = "0xB9")]
	[Token(Token = "0x600044D")]
	public static void EndAuthSession(CSteamID steamID) { }

	[Address(RVA = "0x641DD0", Offset = "0x6411D0", Length = "0x12C")]
	[Token(Token = "0x600044A")]
	public static HAuthTicket GetAuthSessionTicket(Byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSteamNetworkingIdentity) { }

	[Address(RVA = "0x641F00", Offset = "0x641300", Length = "0x20D")]
	[Token(Token = "0x600044B")]
	public static HAuthTicket GetAuthTicketForWebApi(string pchIdentity) { }

	[Address(RVA = "0x642110", Offset = "0x641510", Length = "0xBF")]
	[Token(Token = "0x6000446")]
	public static EVoiceResult GetAvailableVoice(out uint pcbCompressed) { }

	[Address(RVA = "0x6421D0", Offset = "0x6415D0", Length = "0xE7")]
	[Token(Token = "0x600045C")]
	public static SteamAPICall_t GetDurationControl() { }

	[Address(RVA = "0x6422C0", Offset = "0x6416C0", Length = "0xE7")]
	[Token(Token = "0x6000453")]
	public static bool GetEncryptedAppTicket(Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	[Address(RVA = "0x6423B0", Offset = "0x6417B0", Length = "0xC8")]
	[Token(Token = "0x6000454")]
	public static int GetGameBadgeLevel(int nSeries, bool bFoil) { }

	[Address(RVA = "0x642480", Offset = "0x641880", Length = "0xB2")]
	[Token(Token = "0x600043D")]
	public static HSteamUser GetHSteamUser() { }

	[Address(RVA = "0x642540", Offset = "0x641940", Length = "0xE7")]
	[Token(Token = "0x600045B")]
	public static SteamAPICall_t GetMarketEligibility() { }

	[Address(RVA = "0x642630", Offset = "0x641A30", Length = "0xAA")]
	[Token(Token = "0x6000455")]
	public static int GetPlayerSteamLevel() { }

	[Address(RVA = "0x6426E0", Offset = "0x641AE0", Length = "0xE1")]
	[Token(Token = "0x600043F")]
	public static CSteamID GetSteamID() { }

	[Address(RVA = "0x6427D0", Offset = "0x641BD0", Length = "0x158")]
	[Token(Token = "0x6000443")]
	public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer) { }

	[Address(RVA = "0x6429E0", Offset = "0x641DE0", Length = "0x115")]
	[Token(Token = "0x6000447")]
	public static EVoiceResult GetVoice(bool bWantCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten) { }

	[Address(RVA = "0x642930", Offset = "0x641D30", Length = "0xAA")]
	[Token(Token = "0x6000449")]
	public static uint GetVoiceOptimalSampleRate() { }

	[Address(RVA = "0x642B00", Offset = "0x641F00", Length = "0x113")]
	[Token(Token = "0x6000440")]
	public static int InitiateGameConnection_DEPRECATED(Byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) { }

	[Address(RVA = "0x642C20", Offset = "0x642020", Length = "0x10F")]
	[Token(Token = "0x6000452")]
	public static SteamAPICall_t RequestEncryptedAppTicket(Byte[] pDataToInclude, int cbDataToInclude) { }

	[Address(RVA = "0x642D30", Offset = "0x642130", Length = "0x21F")]
	[Token(Token = "0x6000456")]
	public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL) { }

	[Address(RVA = "0x642F50", Offset = "0x642350", Length = "0xAA")]
	[Token(Token = "0x6000444")]
	public static void StartVoiceRecording() { }

	[Address(RVA = "0x643000", Offset = "0x642400", Length = "0xAA")]
	[Token(Token = "0x6000445")]
	public static void StopVoiceRecording() { }

	[Address(RVA = "0x6430B0", Offset = "0x6424B0", Length = "0xC8")]
	[Token(Token = "0x6000441")]
	public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer) { }

	[Address(RVA = "0x643180", Offset = "0x642580", Length = "0x1DB")]
	[Token(Token = "0x6000442")]
	public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "") { }

	[Address(RVA = "0x643360", Offset = "0x642760", Length = "0xC8")]
	[Token(Token = "0x600044F")]
	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

}

