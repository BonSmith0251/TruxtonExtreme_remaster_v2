namespace Steamworks;

[CallbackIdentity(5202)]
[Token(Token = "0x2000085")]
public struct SearchForGameResultCallback_t
{
	[Token(Token = "0x400016E")]
	public const int k_iCallback = 5202; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016F")]
	public ulong m_ullSearchID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000170")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000171")]
	public int m_nCountPlayersInGame; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000172")]
	public int m_nCountAcceptedGame; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000173")]
	public CSteamID m_steamIDHost; //Field offset: 0x14
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000174")]
	public bool m_bFinalCallback; //Field offset: 0x1C

}

