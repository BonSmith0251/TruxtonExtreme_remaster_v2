namespace Steamworks;

[Token(Token = "0x200000E")]
public static class SteamGameServerNetworkingUtils
{

	[Address(RVA = "0x5E4930", Offset = "0x5E3D30", Length = "0x4C")]
	[Token(Token = "0x600016D")]
	public static IntPtr AllocateMessage(int cbAllocateBuffer) { }

	[Address(RVA = "0x5E4980", Offset = "0x5E3D80", Length = "0x55")]
	[Token(Token = "0x6000175")]
	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) { }

	[Address(RVA = "0x5E49E0", Offset = "0x5E3DE0", Length = "0xDC")]
	[Token(Token = "0x6000173")]
	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) { }

	[Address(RVA = "0x5E4AC0", Offset = "0x5E3EC0", Length = "0x5D")]
	[Token(Token = "0x6000171")]
	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	[Address(RVA = "0x5E4B20", Offset = "0x5E3F20", Length = "0x4E")]
	[Token(Token = "0x6000172")]
	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) { }

	[Address(RVA = "0x5E4BF0", Offset = "0x5E3FF0", Length = "0x97")]
	[Token(Token = "0x6000180")]
	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	[Address(RVA = "0x5E4B70", Offset = "0x5E3F70", Length = "0x7B")]
	[Token(Token = "0x6000181")]
	public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	[Address(RVA = "0x5E4C90", Offset = "0x5E4090", Length = "0x4C")]
	[Token(Token = "0x6000177")]
	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) { }

	[Address(RVA = "0x5E4CE0", Offset = "0x5E40E0", Length = "0x4C")]
	[Token(Token = "0x600017D")]
	public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) { }

	[Address(RVA = "0x5E4D30", Offset = "0x5E4130", Length = "0x4E")]
	[Token(Token = "0x6000170")]
	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) { }

	[Address(RVA = "0x5E4D80", Offset = "0x5E4180", Length = "0x4E")]
	[Token(Token = "0x600017A")]
	public static SteamNetworkingMicroseconds GetLocalTimestamp() { }

	[Address(RVA = "0x5E4E80", Offset = "0x5E4280", Length = "0x5B")]
	[Token(Token = "0x6000176")]
	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	[Address(RVA = "0x5E4DD0", Offset = "0x5E41D0", Length = "0x44")]
	[Token(Token = "0x6000178")]
	public static int GetPOPCount() { }

	[Address(RVA = "0x5E4E20", Offset = "0x5E4220", Length = "0x5C")]
	[Token(Token = "0x6000179")]
	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) { }

	[Address(RVA = "0x5E4EE0", Offset = "0x5E42E0", Length = "0x5D")]
	[Token(Token = "0x600017E")]
	public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	[Address(RVA = "0x5E4F40", Offset = "0x5E4340", Length = "0x4E")]
	[Token(Token = "0x600016F")]
	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) { }

	[Address(RVA = "0x5E4F90", Offset = "0x5E4390", Length = "0x44")]
	[Token(Token = "0x600016E")]
	public static void InitRelayNetworkAccess() { }

	[Address(RVA = "0x5E4FE0", Offset = "0x5E43E0", Length = "0x4C")]
	[Token(Token = "0x600017C")]
	public static bool IsFakeIPv4(uint nIPv4) { }

	[Address(RVA = "0x5E5030", Offset = "0x5E4430", Length = "0x5C")]
	[Token(Token = "0x6000182")]
	public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	[Address(RVA = "0x5E5090", Offset = "0x5E4490", Length = "0x125")]
	[Token(Token = "0x6000174")]
	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) { }

	[Address(RVA = "0x5E51C0", Offset = "0x5E45C0", Length = "0x8C")]
	[Token(Token = "0x600017F")]
	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	[Address(RVA = "0x5E5250", Offset = "0x5E4650", Length = "0x5B")]
	[Token(Token = "0x600017B")]
	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	[Address(RVA = "0x5E5530", Offset = "0x5E4930", Length = "0x125")]
	[Token(Token = "0x6000187")]
	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) { }

	[Address(RVA = "0x5E5660", Offset = "0x5E4A60", Length = "0xDC")]
	[Token(Token = "0x6000186")]
	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) { }

	[Address(RVA = "0x5E52B0", Offset = "0x5E46B0", Length = "0x4E")]
	[Token(Token = "0x6000185")]
	public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) { }

	[Address(RVA = "0x5E5300", Offset = "0x5E4700", Length = "0x125")]
	[Token(Token = "0x6000184")]
	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) { }

	[Address(RVA = "0x5E5430", Offset = "0x5E4830", Length = "0xF1")]
	[Token(Token = "0x6000183")]
	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) { }

}

