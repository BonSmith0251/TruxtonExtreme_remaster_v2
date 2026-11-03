namespace Steamworks;

[Token(Token = "0x200016F")]
public enum ESteamNetworkingSocketsDebugOutputType : int
{
	k_ESteamNetworkingSocketsDebugOutputType_None = 0,
	k_ESteamNetworkingSocketsDebugOutputType_Bug = 1,
	k_ESteamNetworkingSocketsDebugOutputType_Error = 2,
	k_ESteamNetworkingSocketsDebugOutputType_Important = 3,
	k_ESteamNetworkingSocketsDebugOutputType_Warning = 4,
	k_ESteamNetworkingSocketsDebugOutputType_Msg = 5,
	k_ESteamNetworkingSocketsDebugOutputType_Verbose = 6,
	k_ESteamNetworkingSocketsDebugOutputType_Debug = 7,
	k_ESteamNetworkingSocketsDebugOutputType_Everything = 8,
	k_ESteamNetworkingSocketsDebugOutputType__Force32Bit = 2147483647,
}

