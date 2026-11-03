namespace Steamworks;

[Token(Token = "0x20001EA")]
public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
{
	[Token(Token = "0x4000B5B")]
	public static readonly ScreenshotHandle Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B5C")]
	public uint m_ScreenshotHandle; //Field offset: 0x0

	[Address(RVA = "0x639EF0", Offset = "0x6392F0", Length = "0x39")]
	[Token(Token = "0x6000B84")]
	private static ScreenshotHandle() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000B7A")]
	public ScreenshotHandle(uint value) { }

	[Address(RVA = "0x604120", Offset = "0x603520", Length = "0x8")]
	[Token(Token = "0x6000B83")]
	public override int CompareTo(ScreenshotHandle other) { }

	[Address(RVA = "0x639E50", Offset = "0x639250", Length = "0x97")]
	[Token(Token = "0x6000B7C")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000B82")]
	public override bool Equals(ScreenshotHandle other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000B7D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000B7E")]
	public static bool op_Equality(ScreenshotHandle x, ScreenshotHandle y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B80")]
	public static ScreenshotHandle op_Explicit(uint value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000B81")]
	public static uint op_Explicit(ScreenshotHandle that) { }

	[Address(RVA = "0x639F30", Offset = "0x639330", Length = "0x4F")]
	[Token(Token = "0x6000B7F")]
	public static bool op_Inequality(ScreenshotHandle x, ScreenshotHandle y) { }

	[Address(RVA = "0x6041F0", Offset = "0x6035F0", Length = "0x7")]
	[Token(Token = "0x6000B7B")]
	public virtual string ToString() { }

}

