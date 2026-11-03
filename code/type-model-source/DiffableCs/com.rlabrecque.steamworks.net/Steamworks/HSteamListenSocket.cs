namespace Steamworks;

[Token(Token = "0x20001DA")]
public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket>
{
	[Token(Token = "0x4000B0A")]
	public static readonly HSteamListenSocket Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B0B")]
	public uint m_HSteamListenSocket; //Field offset: 0x0

	[Address(RVA = "0x60B6A0", Offset = "0x60AAA0", Length = "0x39")]
	[Token(Token = "0x6000AEE")]
	private static HSteamListenSocket() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000AE4")]
	public HSteamListenSocket(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000AED")]
	public override int CompareTo(HSteamListenSocket other) { }

	[Address(RVA = "0x60B600", Offset = "0x60AA00", Length = "0x97")]
	[Token(Token = "0x6000AE6")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000AEC")]
	public override bool Equals(HSteamListenSocket other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000AE7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000AE8")]
	public static bool op_Equality(HSteamListenSocket x, HSteamListenSocket y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AEA")]
	public static HSteamListenSocket op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000AEB")]
	public static uint op_Explicit(HSteamListenSocket that) { }

	[Address(RVA = "0x60B6E0", Offset = "0x60AAE0", Length = "0x4F")]
	[Token(Token = "0x6000AE9")]
	public static bool op_Inequality(HSteamListenSocket x, HSteamListenSocket y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000AE5")]
	public virtual string ToString() { }

}

