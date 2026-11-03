namespace Steamworks;

[Token(Token = "0x2000142")]
public enum ELeaderboardDataRequest : int
{
	k_ELeaderboardDataRequestGlobal = 0,
	k_ELeaderboardDataRequestGlobalAroundUser = 1,
	k_ELeaderboardDataRequestFriends = 2,
	k_ELeaderboardDataRequestUsers = 3,
}

