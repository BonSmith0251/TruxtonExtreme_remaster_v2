namespace Steamworks;

[CallbackIdentity(5201)]
[Token(Token = "0x2000084")]
public struct SearchForGameProgressCallback_t
{
	[Token(Token = "0x4000167")]
	public const int k_iCallback = 5201; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000168")]
	public ulong m_ullSearchID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000169")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400016A")]
	public CSteamID m_lobbyID; //Field offset: 0xC
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400016B")]
	public CSteamID m_steamIDEndedSearch; //Field offset: 0x14
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400016C")]
	public int m_nSecondsRemainingEstimate; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016D")]
	public int m_cPlayersSearching; //Field offset: 0x20

}

