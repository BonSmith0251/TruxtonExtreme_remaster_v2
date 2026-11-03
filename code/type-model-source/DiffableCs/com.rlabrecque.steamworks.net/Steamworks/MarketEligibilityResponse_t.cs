namespace Steamworks;

[CallbackIdentity(166)]
[Token(Token = "0x20000E7")]
public struct MarketEligibilityResponse_t
{
	[Token(Token = "0x40002C4")]
	public const int k_iCallback = 166; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C5")]
	public bool m_bAllowed; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002C6")]
	public EMarketNotAllowedReasonFlags m_eNotAllowedReason; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002C7")]
	public RTime32 m_rtAllowedAtTime; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002C8")]
	public int m_cdaySteamGuardRequiredDays; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C9")]
	public int m_cdayNewDeviceCooldown; //Field offset: 0x10

}

