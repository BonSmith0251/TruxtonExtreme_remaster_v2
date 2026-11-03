namespace Steamworks;

[Token(Token = "0x20001BD")]
public struct SteamDatagramHostedAddress
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AD2")]
	public int m_cbSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AD3")]
	public Byte[] m_data; //Field offset: 0x8

	[Address(RVA = "0x63AE90", Offset = "0x63A290", Length = "0x51")]
	[Token(Token = "0x6000A2E")]
	public void Clear() { }

}

