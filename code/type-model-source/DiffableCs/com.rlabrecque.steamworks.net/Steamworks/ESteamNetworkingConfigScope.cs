namespace Steamworks;

[Token(Token = "0x200016B")]
public enum ESteamNetworkingConfigScope : int
{
	k_ESteamNetworkingConfig_Global = 1,
	k_ESteamNetworkingConfig_SocketsInterface = 2,
	k_ESteamNetworkingConfig_ListenSocket = 3,
	k_ESteamNetworkingConfig_Connection = 4,
	k_ESteamNetworkingConfigScope__Force32Bit = 2147483647,
}

