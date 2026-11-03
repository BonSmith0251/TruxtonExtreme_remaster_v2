namespace Steamworks;

[CallbackIdentity(1104)]
[Token(Token = "0x20000ED")]
public struct LeaderboardFindResult_t
{
	[Token(Token = "0x40002E5")]
	public const int k_iCallback = 1104; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E6")]
	public SteamLeaderboard_t m_hSteamLeaderboard; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002E7")]
	public byte m_bLeaderboardFound; //Field offset: 0x8

}

