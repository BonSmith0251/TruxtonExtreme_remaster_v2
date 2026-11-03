namespace System.Net;

[Token(Token = "0x200025B")]
internal class CaseInsensitiveAscii : IEqualityComparer, IComparer
{
	[Token(Token = "0x400099C")]
	internal static readonly CaseInsensitiveAscii StaticInstance; //Field offset: 0x0
	[Token(Token = "0x400099D")]
	internal static readonly Byte[] AsciiToLower; //Field offset: 0x8

	[Address(RVA = "0x26988C0", Offset = "0x2697CC0", Length = "0xD1")]
	[Token(Token = "0x6000FD8")]
	private static CaseInsensitiveAscii() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000FD7")]
	public CaseInsensitiveAscii() { }

	[Address(RVA = "0x26983E0", Offset = "0x26977E0", Length = "0x16F")]
	[Token(Token = "0x6000FD4")]
	public override int Compare(object firstObject, object secondObject) { }

	[Address(RVA = "0x2698550", Offset = "0x2697950", Length = "0x16B")]
	[Token(Token = "0x6000FD6")]
	public override bool Equals(object firstObject, object secondObject) { }

	[Address(RVA = "0x26986C0", Offset = "0x2697AC0", Length = "0xEF")]
	[Token(Token = "0x6000FD5")]
	private int FastGetHashCode(string myString) { }

	[Address(RVA = "0x26987B0", Offset = "0x2697BB0", Length = "0x10A")]
	[Token(Token = "0x6000FD3")]
	public override int GetHashCode(object myObject) { }

}

