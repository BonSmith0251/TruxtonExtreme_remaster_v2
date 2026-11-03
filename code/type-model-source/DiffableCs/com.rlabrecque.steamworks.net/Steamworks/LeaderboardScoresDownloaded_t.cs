namespace Steamworks;

[CallbackIdentity(1105)]
[Token(Token = "0x20000EE")]
public struct LeaderboardScoresDownloaded_t
{
	[Token(Token = "0x40002E8")]
	public const int k_iCallback = 1105; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E9")]
	public SteamLeaderboard_t m_hSteamLeaderboard; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002EA")]
	public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002EB")]
	public int m_cEntryCount; //Field offset: 0x10

}

