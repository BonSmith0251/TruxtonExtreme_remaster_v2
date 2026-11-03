namespace Steamworks;

[Token(Token = "0x200016E")]
public enum ESteamNetworkingGetConfigValueResult : int
{
	k_ESteamNetworkingGetConfigValue_BadValue = -1,
	k_ESteamNetworkingGetConfigValue_BadScopeObj = -2,
	k_ESteamNetworkingGetConfigValue_BufferTooSmall = -3,
	k_ESteamNetworkingGetConfigValue_OK = 1,
	k_ESteamNetworkingGetConfigValue_OKInherited = 2,
	k_ESteamNetworkingGetConfigValueResult__Force32Bit = 2147483647,
}

