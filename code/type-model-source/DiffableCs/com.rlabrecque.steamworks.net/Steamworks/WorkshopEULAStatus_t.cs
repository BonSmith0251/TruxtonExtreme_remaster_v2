namespace Steamworks;

[CallbackIdentity(3420)]
[Token(Token = "0x20000DA")]
public struct WorkshopEULAStatus_t
{
	[Token(Token = "0x400029D")]
	public const int k_iCallback = 3420; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029E")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400029F")]
	public AppId_t m_nAppID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002A0")]
	public uint m_unVersion; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002A1")]
	public RTime32 m_rtAction; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A2")]
	public bool m_bAccepted; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40002A3")]
	public bool m_bNeedsAction; //Field offset: 0x11

}

