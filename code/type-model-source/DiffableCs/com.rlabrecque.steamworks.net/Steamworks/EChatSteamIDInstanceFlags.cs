namespace Steamworks;

[Flags]
[Token(Token = "0x2000158")]
public enum EChatSteamIDInstanceFlags : int
{
	k_EChatAccountInstanceMask = 4095,
	k_EChatInstanceFlagClan = 524288,
	k_EChatInstanceFlagLobby = 262144,
	k_EChatInstanceFlagMMSLobby = 131072,
}

