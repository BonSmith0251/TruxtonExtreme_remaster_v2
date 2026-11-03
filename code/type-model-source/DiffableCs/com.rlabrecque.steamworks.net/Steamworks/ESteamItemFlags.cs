namespace Steamworks;

[Flags]
[Token(Token = "0x200011C")]
public enum ESteamItemFlags : int
{
	k_ESteamItemNoTrade = 1,
	k_ESteamItemRemoved = 256,
	k_ESteamItemConsumed = 512,
}

