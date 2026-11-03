namespace Steamworks;

[Token(Token = "0x2000168")]
public enum ESteamNetworkingFakeIPType : int
{
	k_ESteamNetworkingFakeIPType_Invalid = 0,
	k_ESteamNetworkingFakeIPType_NotFake = 1,
	k_ESteamNetworkingFakeIPType_GlobalIPv4 = 2,
	k_ESteamNetworkingFakeIPType_LocalIPv4 = 3,
	k_ESteamNetworkingFakeIPType__Force32Bit = 2147483647,
}

