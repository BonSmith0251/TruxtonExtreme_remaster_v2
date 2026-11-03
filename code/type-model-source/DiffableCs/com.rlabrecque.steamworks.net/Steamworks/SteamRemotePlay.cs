namespace Steamworks;

[Token(Token = "0x2000021")]
public static class SteamRemotePlay
{

	[Address(RVA = "0x5FB490", Offset = "0x5FA890", Length = "0x75")]
	[Token(Token = "0x6000394")]
	public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	[Address(RVA = "0x5FB510", Offset = "0x5FA910", Length = "0x51")]
	[Token(Token = "0x6000396")]
	public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) { }

	[Address(RVA = "0x5FB570", Offset = "0x5FA970", Length = "0x51")]
	[Token(Token = "0x6000395")]
	public static bool BStartRemotePlayTogether(bool bShowOverlay = true) { }

	[Address(RVA = "0x5FB5D0", Offset = "0x5FA9D0", Length = "0x4F")]
	[Token(Token = "0x6000393")]
	public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) { }

	[Address(RVA = "0x5FB620", Offset = "0x5FAA20", Length = "0x59")]
	[Token(Token = "0x6000392")]
	public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) { }

	[Address(RVA = "0x5FB680", Offset = "0x5FAA80", Length = "0x47")]
	[Token(Token = "0x600038F")]
	public static uint GetSessionCount() { }

	[Address(RVA = "0x5FB6D0", Offset = "0x5FAAD0", Length = "0x58")]
	[Token(Token = "0x6000390")]
	public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) { }

	[Address(RVA = "0x5FB730", Offset = "0x5FAB30", Length = "0x8D")]
	[Token(Token = "0x6000391")]
	public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) { }

}

