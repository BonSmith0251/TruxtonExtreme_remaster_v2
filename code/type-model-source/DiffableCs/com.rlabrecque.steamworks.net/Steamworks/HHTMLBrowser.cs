namespace Steamworks;

[Token(Token = "0x20001C3")]
public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
{
	[Token(Token = "0x4000AEA")]
	public static readonly HHTMLBrowser Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AEB")]
	public uint m_HHTMLBrowser; //Field offset: 0x0

	[Address(RVA = "0x60B2D0", Offset = "0x60A6D0", Length = "0x39")]
	[Token(Token = "0x6000A45")]
	private static HHTMLBrowser() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000A3B")]
	public HHTMLBrowser(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000A44")]
	public override int CompareTo(HHTMLBrowser other) { }

	[Address(RVA = "0x60B230", Offset = "0x60A630", Length = "0x97")]
	[Token(Token = "0x6000A3D")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000A43")]
	public override bool Equals(HHTMLBrowser other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000A3E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000A3F")]
	public static bool op_Equality(HHTMLBrowser x, HHTMLBrowser y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A41")]
	public static HHTMLBrowser op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A42")]
	public static uint op_Explicit(HHTMLBrowser that) { }

	[Address(RVA = "0x60B310", Offset = "0x60A710", Length = "0x4F")]
	[Token(Token = "0x6000A40")]
	public static bool op_Inequality(HHTMLBrowser x, HHTMLBrowser y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000A3C")]
	public virtual string ToString() { }

}

