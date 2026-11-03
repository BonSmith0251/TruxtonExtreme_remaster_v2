namespace Steamworks;

[CallbackIdentity(5213)]
[Token(Token = "0x2000088")]
public struct RequestPlayersForGameFinalResultCallback_t
{
	[Token(Token = "0x4000183")]
	public const int k_iCallback = 5213; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000184")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000185")]
	public ulong m_ullSearchID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000186")]
	public ulong m_ullUniqueGameID; //Field offset: 0x10

}

