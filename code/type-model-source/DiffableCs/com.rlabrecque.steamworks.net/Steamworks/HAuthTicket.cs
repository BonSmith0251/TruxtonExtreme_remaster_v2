namespace Steamworks;

[Token(Token = "0x20001BC")]
public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
{
	[Token(Token = "0x4000AD0")]
	public static readonly HAuthTicket Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AD1")]
	public uint m_HAuthTicket; //Field offset: 0x0

	[Address(RVA = "0x60B1A0", Offset = "0x60A5A0", Length = "0x39")]
	[Token(Token = "0x6000A2D")]
	private static HAuthTicket() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000A23")]
	public HAuthTicket(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000A2C")]
	public override int CompareTo(HAuthTicket other) { }

	[Address(RVA = "0x60B100", Offset = "0x60A500", Length = "0x97")]
	[Token(Token = "0x6000A25")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000A2B")]
	public override bool Equals(HAuthTicket other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000A26")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000A27")]
	public static bool op_Equality(HAuthTicket x, HAuthTicket y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A29")]
	public static HAuthTicket op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A2A")]
	public static uint op_Explicit(HAuthTicket that) { }

	[Address(RVA = "0x60B1E0", Offset = "0x60A5E0", Length = "0x4F")]
	[Token(Token = "0x6000A28")]
	public static bool op_Inequality(HAuthTicket x, HAuthTicket y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000A24")]
	public virtual string ToString() { }

}

