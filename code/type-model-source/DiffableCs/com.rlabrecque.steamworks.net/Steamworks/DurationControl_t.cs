namespace Steamworks;

[CallbackIdentity(167)]
[Token(Token = "0x20000E8")]
public struct DurationControl_t
{
	[Token(Token = "0x40002CA")]
	public const int k_iCallback = 167; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002CB")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002CC")]
	public AppId_t m_appid; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002CD")]
	public bool m_bApplicable; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002CE")]
	public int m_csecsLast5h; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002CF")]
	public EDurationControlProgress m_progress; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002D0")]
	public EDurationControlNotification m_notification; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D1")]
	public int m_csecsToday; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002D2")]
	public int m_csecsRemaining; //Field offset: 0x1C

}

