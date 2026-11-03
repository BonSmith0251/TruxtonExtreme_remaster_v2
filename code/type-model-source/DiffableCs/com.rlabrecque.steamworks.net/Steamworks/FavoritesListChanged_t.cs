namespace Steamworks;

[CallbackIdentity(502)]
[Token(Token = "0x2000079")]
public struct FavoritesListChanged_t
{
	[Token(Token = "0x4000138")]
	public const int k_iCallback = 502; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000139")]
	public uint m_nIP; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400013A")]
	public uint m_nQueryPort; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013B")]
	public uint m_nConnPort; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400013C")]
	public uint m_nAppID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013D")]
	public uint m_nFlags; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400013E")]
	public bool m_bAdd; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400013F")]
	public AccountID_t m_unAccountId; //Field offset: 0x18

}

