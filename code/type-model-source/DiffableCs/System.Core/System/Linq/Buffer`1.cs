namespace System.Linq;

[Token(Token = "0x2000040")]
internal struct Buffer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BF")]
	internal TElement[] items; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C0")]
	internal int count; //Field offset: 0x0

	[Address(RVA = "0x16B9DD0", Offset = "0x16B91D0", Length = "0x594")]
	[Token(Token = "0x6000183")]
	internal Buffer`1(IEnumerable<TElement> source) { }

	[Address(RVA = "0x16B7880", Offset = "0x16B6C80", Length = "0xE8")]
	[Token(Token = "0x6000184")]
	internal TElement[] ToArray() { }

}

