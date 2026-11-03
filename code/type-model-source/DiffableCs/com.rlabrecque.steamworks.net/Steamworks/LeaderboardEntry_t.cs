namespace Steamworks;

[Token(Token = "0x200017B")]
public struct LeaderboardEntry_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A21")]
	public CSteamID m_steamIDUser; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A22")]
	public int m_nGlobalRank; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A23")]
	public int m_nScore; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A24")]
	public int m_cDetails; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A25")]
	public UGCHandle_t m_hUGC; //Field offset: 0x18

}

