namespace Steamworks;

[Token(Token = "0x2000146")]
public enum ESteamAPICallFailure : int
{
	k_ESteamAPICallFailureNone = -1,
	k_ESteamAPICallFailureSteamGone = 0,
	k_ESteamAPICallFailureNetworkFailure = 1,
	k_ESteamAPICallFailureInvalidHandle = 2,
	k_ESteamAPICallFailureMismatchedCallback = 3,
}

