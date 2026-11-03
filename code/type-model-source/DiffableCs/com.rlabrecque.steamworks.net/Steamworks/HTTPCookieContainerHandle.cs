namespace Steamworks;

[Token(Token = "0x20001C4")]
public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
{
	[Token(Token = "0x4000AEC")]
	public static readonly HTTPCookieContainerHandle Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AED")]
	public uint m_HTTPCookieContainerHandle; //Field offset: 0x0

	[Address(RVA = "0x60BA30", Offset = "0x60AE30", Length = "0x39")]
	[Token(Token = "0x6000A50")]
	private static HTTPCookieContainerHandle() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000A46")]
	public HTTPCookieContainerHandle(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000A4F")]
	public override int CompareTo(HTTPCookieContainerHandle other) { }

	[Address(RVA = "0x60B990", Offset = "0x60AD90", Length = "0x97")]
	[Token(Token = "0x6000A48")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000A4E")]
	public override bool Equals(HTTPCookieContainerHandle other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000A49")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000A4A")]
	public static bool op_Equality(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A4C")]
	public static HTTPCookieContainerHandle op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A4D")]
	public static uint op_Explicit(HTTPCookieContainerHandle that) { }

	[Address(RVA = "0x60BA70", Offset = "0x60AE70", Length = "0x4F")]
	[Token(Token = "0x6000A4B")]
	public static bool op_Inequality(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000A47")]
	public virtual string ToString() { }

}

