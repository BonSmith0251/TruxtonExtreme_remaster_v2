namespace Steamworks;

[Token(Token = "0x20001E1")]
public struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr>
{
	[Token(Token = "0x4000B41")]
	public const int k_cchMaxString = 48; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B3F")]
	public Byte[] m_ipv6; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B40")]
	public ushort m_port; //Field offset: 0x8

	[Address(RVA = "0x635FA0", Offset = "0x6353A0", Length = "0xC7")]
	[Token(Token = "0x6000B20")]
	public void Clear() { }

	[Address(RVA = "0x636230", Offset = "0x635630", Length = "0x129")]
	[Token(Token = "0x6000B2A")]
	public override bool Equals(SteamNetworkingIPAddr x) { }

	[Address(RVA = "0x636070", Offset = "0x635470", Length = "0xDA")]
	[Token(Token = "0x6000B2B")]
	public ESteamNetworkingFakeIPType GetFakeIPType() { }

	[Address(RVA = "0x636150", Offset = "0x635550", Length = "0xDA")]
	[Token(Token = "0x6000B25")]
	public uint GetIPv4() { }

	[Address(RVA = "0x63B5F0", Offset = "0x63A9F0", Length = "0x16")]
	[Token(Token = "0x6000B2C")]
	public bool IsFakeIP() { }

	[Address(RVA = "0x636440", Offset = "0x635840", Length = "0xDE")]
	[Token(Token = "0x6000B24")]
	public bool IsIPv4() { }

	[Address(RVA = "0x636520", Offset = "0x635920", Length = "0xDE")]
	[Token(Token = "0x6000B21")]
	public bool IsIPv6AllZeros() { }

	[Address(RVA = "0x636600", Offset = "0x635A00", Length = "0xDE")]
	[Token(Token = "0x6000B27")]
	public bool IsLocalHost() { }

	[Address(RVA = "0x63B610", Offset = "0x63AA10", Length = "0x210")]
	[Token(Token = "0x6000B29")]
	public bool ParseString(string pszStr) { }

	[Address(RVA = "0x636830", Offset = "0x635C30", Length = "0xE4")]
	[Token(Token = "0x6000B23")]
	public void SetIPv4(uint nIP, ushort nPort) { }

	[Address(RVA = "0x636A00", Offset = "0x635E00", Length = "0xF0")]
	[Token(Token = "0x6000B22")]
	public void SetIPv6(Byte[] ipv6, ushort nPort) { }

	[Address(RVA = "0x636920", Offset = "0x635D20", Length = "0xD9")]
	[Token(Token = "0x6000B26")]
	public void SetIPv6LocalHost(ushort nPort = 0) { }

	[Address(RVA = "0x63B830", Offset = "0x63AC30", Length = "0x15A")]
	[Token(Token = "0x6000B28")]
	public void ToString(out string buf, bool bWithPort) { }

}

