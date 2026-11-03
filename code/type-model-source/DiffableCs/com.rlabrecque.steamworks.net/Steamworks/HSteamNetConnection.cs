namespace Steamworks;

[Token(Token = "0x20001DB")]
public struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection>
{
	[Token(Token = "0x4000B0C")]
	public static readonly HSteamNetConnection Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B0D")]
	public uint m_HSteamNetConnection; //Field offset: 0x0

	[Address(RVA = "0x60B7D0", Offset = "0x60ABD0", Length = "0x39")]
	[Token(Token = "0x6000AF9")]
	private static HSteamNetConnection() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000AEF")]
	public HSteamNetConnection(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000AF8")]
	public override int CompareTo(HSteamNetConnection other) { }

	[Address(RVA = "0x60B730", Offset = "0x60AB30", Length = "0x97")]
	[Token(Token = "0x6000AF1")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000AF7")]
	public override bool Equals(HSteamNetConnection other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000AF2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000AF3")]
	public static bool op_Equality(HSteamNetConnection x, HSteamNetConnection y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AF5")]
	public static HSteamNetConnection op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AF6")]
	public static uint op_Explicit(HSteamNetConnection that) { }

	[Address(RVA = "0x60B810", Offset = "0x60AC10", Length = "0x4F")]
	[Token(Token = "0x6000AF4")]
	public static bool op_Inequality(HSteamNetConnection x, HSteamNetConnection y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000AF0")]
	public virtual string ToString() { }

}

