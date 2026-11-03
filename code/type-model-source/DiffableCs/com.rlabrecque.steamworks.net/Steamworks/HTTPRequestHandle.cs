namespace Steamworks;

[Token(Token = "0x20001C5")]
public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
{
	[Token(Token = "0x4000AEE")]
	public static readonly HTTPRequestHandle Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AEF")]
	public uint m_HTTPRequestHandle; //Field offset: 0x0

	[Address(RVA = "0x60BB60", Offset = "0x60AF60", Length = "0x39")]
	[Token(Token = "0x6000A5B")]
	private static HTTPRequestHandle() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000A51")]
	public HTTPRequestHandle(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000A5A")]
	public override int CompareTo(HTTPRequestHandle other) { }

	[Address(RVA = "0x60BAC0", Offset = "0x60AEC0", Length = "0x97")]
	[Token(Token = "0x6000A53")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000A59")]
	public override bool Equals(HTTPRequestHandle other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000A54")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000A55")]
	public static bool op_Equality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A57")]
	public static HTTPRequestHandle op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A58")]
	public static uint op_Explicit(HTTPRequestHandle that) { }

	[Address(RVA = "0x60BBA0", Offset = "0x60AFA0", Length = "0x4F")]
	[Token(Token = "0x6000A56")]
	public static bool op_Inequality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000A52")]
	public virtual string ToString() { }

}

