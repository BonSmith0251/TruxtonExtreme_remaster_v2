namespace Steamworks;

[Token(Token = "0x200001F")]
public static class SteamNetworkingUtils
{

	[Address(RVA = "0x5F9210", Offset = "0x5F8610", Length = "0x4F")]
	[Token(Token = "0x600036E")]
	public static IntPtr AllocateMessage(int cbAllocateBuffer) { }

	[Address(RVA = "0x5F9260", Offset = "0x5F8660", Length = "0x58")]
	[Token(Token = "0x6000376")]
	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) { }

	[Address(RVA = "0x5F92C0", Offset = "0x5F86C0", Length = "0xDF")]
	[Token(Token = "0x6000374")]
	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) { }

	[Address(RVA = "0x5F93A0", Offset = "0x5F87A0", Length = "0x60")]
	[Token(Token = "0x6000372")]
	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	[Address(RVA = "0x5F9400", Offset = "0x5F8800", Length = "0x51")]
	[Token(Token = "0x6000373")]
	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) { }

	[Address(RVA = "0x5F94E0", Offset = "0x5F88E0", Length = "0x9A")]
	[Token(Token = "0x6000381")]
	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	[Address(RVA = "0x5F9460", Offset = "0x5F8860", Length = "0x7E")]
	[Token(Token = "0x6000382")]
	public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	[Address(RVA = "0x5F9580", Offset = "0x5F8980", Length = "0x4F")]
	[Token(Token = "0x6000378")]
	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) { }

	[Address(RVA = "0x5F95D0", Offset = "0x5F89D0", Length = "0x4F")]
	[Token(Token = "0x600037E")]
	public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) { }

	[Address(RVA = "0x5F9620", Offset = "0x5F8A20", Length = "0x51")]
	[Token(Token = "0x6000371")]
	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) { }

	[Address(RVA = "0x5F9680", Offset = "0x5F8A80", Length = "0x51")]
	[Token(Token = "0x600037B")]
	public static SteamNetworkingMicroseconds GetLocalTimestamp() { }

	[Address(RVA = "0x5F9790", Offset = "0x5F8B90", Length = "0x5E")]
	[Token(Token = "0x6000377")]
	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	[Address(RVA = "0x5F96E0", Offset = "0x5F8AE0", Length = "0x47")]
	[Token(Token = "0x6000379")]
	public static int GetPOPCount() { }

	[Address(RVA = "0x5F9730", Offset = "0x5F8B30", Length = "0x5F")]
	[Token(Token = "0x600037A")]
	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) { }

	[Address(RVA = "0x5F97F0", Offset = "0x5F8BF0", Length = "0x60")]
	[Token(Token = "0x600037F")]
	public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	[Address(RVA = "0x5F9850", Offset = "0x5F8C50", Length = "0x51")]
	[Token(Token = "0x6000370")]
	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) { }

	[Address(RVA = "0x5F98B0", Offset = "0x5F8CB0", Length = "0x47")]
	[Token(Token = "0x600036F")]
	public static void InitRelayNetworkAccess() { }

	[Address(RVA = "0x5F9900", Offset = "0x5F8D00", Length = "0x4F")]
	[Token(Token = "0x600037D")]
	public static bool IsFakeIPv4(uint nIPv4) { }

	[Address(RVA = "0x5F9950", Offset = "0x5F8D50", Length = "0x5F")]
	[Token(Token = "0x6000383")]
	public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	[Address(RVA = "0x5F99B0", Offset = "0x5F8DB0", Length = "0x128")]
	[Token(Token = "0x6000375")]
	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) { }

	[Address(RVA = "0x5F9AE0", Offset = "0x5F8EE0", Length = "0x8F")]
	[Token(Token = "0x6000380")]
	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	[Address(RVA = "0x5F9B70", Offset = "0x5F8F70", Length = "0x5E")]
	[Token(Token = "0x600037C")]
	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	[Address(RVA = "0x5F9E60", Offset = "0x5F9260", Length = "0x128")]
	[Token(Token = "0x6000388")]
	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) { }

	[Address(RVA = "0x5F9F90", Offset = "0x5F9390", Length = "0xDF")]
	[Token(Token = "0x6000387")]
	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) { }

	[Address(RVA = "0x5F9BD0", Offset = "0x5F8FD0", Length = "0x51")]
	[Token(Token = "0x6000386")]
	public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) { }

	[Address(RVA = "0x5F9C30", Offset = "0x5F9030", Length = "0x128")]
	[Token(Token = "0x6000385")]
	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) { }

	[Address(RVA = "0x5F9D60", Offset = "0x5F9160", Length = "0xF4")]
	[Token(Token = "0x6000384")]
	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) { }

}

