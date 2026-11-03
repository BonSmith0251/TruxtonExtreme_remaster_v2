namespace Steamworks;

[Token(Token = "0x20001E3")]
public struct SteamNetworkingMicroseconds : IEquatable<SteamNetworkingMicroseconds>, IComparable<SteamNetworkingMicroseconds>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B50")]
	public long m_SteamNetworkingMicroseconds; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000B30")]
	public SteamNetworkingMicroseconds(long value) { }

	[Address(RVA = "0x63C590", Offset = "0x63B990", Length = "0x8")]
	[Token(Token = "0x6000B39")]
	public override int CompareTo(SteamNetworkingMicroseconds other) { }

	[Address(RVA = "0x63C5A0", Offset = "0x63B9A0", Length = "0x81")]
	[Token(Token = "0x6000B32")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000B38")]
	public override bool Equals(SteamNetworkingMicroseconds other) { }

	[Address(RVA = "0x63C630", Offset = "0x63BA30", Length = "0x7")]
	[Token(Token = "0x6000B33")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000B34")]
	public static bool op_Equality(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B36")]
	public static SteamNetworkingMicroseconds op_Explicit(long value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B37")]
	public static long op_Explicit(SteamNetworkingMicroseconds that) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000B35")]
	public static bool op_Inequality(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y) { }

	[Address(RVA = "0x63C640", Offset = "0x63BA40", Length = "0x7")]
	[Token(Token = "0x6000B31")]
	public virtual string ToString() { }

}

