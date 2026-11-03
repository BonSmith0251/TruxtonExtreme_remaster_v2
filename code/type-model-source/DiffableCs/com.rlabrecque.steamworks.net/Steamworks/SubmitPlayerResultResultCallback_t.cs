namespace Steamworks;

[CallbackIdentity(5214)]
[Token(Token = "0x2000089")]
public struct SubmitPlayerResultResultCallback_t
{
	[Token(Token = "0x4000187")]
	public const int k_iCallback = 5214; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000188")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000189")]
	public ulong ullUniqueGameID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400018A")]
	public CSteamID steamIDPlayer; //Field offset: 0x10

}

