namespace Steamworks;

[Token(Token = "0x200016C")]
public enum ESteamNetworkingConfigDataType : int
{
	k_ESteamNetworkingConfig_Int32 = 1,
	k_ESteamNetworkingConfig_Int64 = 2,
	k_ESteamNetworkingConfig_Float = 3,
	k_ESteamNetworkingConfig_String = 4,
	k_ESteamNetworkingConfig_Ptr = 5,
	k_ESteamNetworkingConfigDataType__Force32Bit = 2147483647,
}

