namespace Steamworks;

[Token(Token = "0x20001F1")]
public struct SteamIPAddress_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B68")]
	private long m_ip0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B69")]
	private long m_ip1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B6A")]
	private ESteamIPType m_eType; //Field offset: 0x10

	[Address(RVA = "0x646F00", Offset = "0x646300", Length = "0x3A0")]
	[Token(Token = "0x6000BC6")]
	public SteamIPAddress_t(IPAddress iPAddress) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000BC9")]
	public ESteamIPType GetIPType() { }

	[Address(RVA = "0x646D50", Offset = "0x646150", Length = "0x12")]
	[Token(Token = "0x6000BCA")]
	public bool IsSet() { }

	[Address(RVA = "0x646D70", Offset = "0x646170", Length = "0x14B")]
	[Token(Token = "0x6000BC7")]
	public IPAddress ToIPAddress() { }

	[Address(RVA = "0x646EC0", Offset = "0x6462C0", Length = "0x30")]
	[Token(Token = "0x6000BC8")]
	public virtual string ToString() { }

}

