namespace TMPro;

[Token(Token = "0x2000026")]
public struct Extents
{
	[Token(Token = "0x40000DB")]
	internal static Extents zero; //Field offset: 0x0
	[Token(Token = "0x40000DC")]
	internal static Extents uninitialized; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DD")]
	public Vector2 min; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DE")]
	public Vector2 max; //Field offset: 0x8

	[Address(RVA = "0x2EAE880", Offset = "0x2EADC80", Length = "0xE4")]
	[Token(Token = "0x6000145")]
	private static Extents() { }

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x6000143")]
	public Extents(Vector2 min, Vector2 max) { }

	[Address(RVA = "0x2EAE6A0", Offset = "0x2EADAA0", Length = "0x1DE")]
	[Token(Token = "0x6000144")]
	public virtual string ToString() { }

}

