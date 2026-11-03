namespace Steamworks;

[Token(Token = "0x200014D")]
public enum ESteamAPIInitResult : int
{
	k_ESteamAPIInitResult_OK = 0,
	k_ESteamAPIInitResult_FailedGeneric = 1,
	k_ESteamAPIInitResult_NoSteamClient = 2,
	k_ESteamAPIInitResult_VersionMismatch = 3,
}

