namespace Steamworks;

[CallbackIdentity(1106)]
[Token(Token = "0x20000EF")]
public struct LeaderboardScoreUploaded_t
{
	[Token(Token = "0x40002EC")]
	public const int k_iCallback = 1106; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002ED")]
	public byte m_bSuccess; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002EE")]
	public SteamLeaderboard_t m_hSteamLeaderboard; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002EF")]
	public int m_nScore; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002F0")]
	public byte m_bScoreChanged; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F1")]
	public int m_nGlobalRankNew; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002F2")]
	public int m_nGlobalRankPrevious; //Field offset: 0x1C

}

