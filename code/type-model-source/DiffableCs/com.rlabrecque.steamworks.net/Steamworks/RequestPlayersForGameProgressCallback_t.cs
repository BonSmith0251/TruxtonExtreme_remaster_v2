namespace Steamworks;

[CallbackIdentity(5211)]
[Token(Token = "0x2000086")]
public struct RequestPlayersForGameProgressCallback_t
{
	[Token(Token = "0x4000175")]
	public const int k_iCallback = 5211; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000176")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000177")]
	public ulong m_ullSearchID; //Field offset: 0x8

}

