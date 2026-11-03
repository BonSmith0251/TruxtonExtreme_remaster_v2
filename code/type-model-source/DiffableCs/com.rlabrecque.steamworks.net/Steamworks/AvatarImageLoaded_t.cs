namespace Steamworks;

[CallbackIdentity(334)]
[Token(Token = "0x2000034")]
public struct AvatarImageLoaded_t
{
	[Token(Token = "0x4000028")]
	public const int k_iCallback = 334; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000029")]
	public CSteamID m_steamID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002A")]
	public int m_iImage; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400002B")]
	public int m_iWide; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002C")]
	public int m_iTall; //Field offset: 0x10

}

