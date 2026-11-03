namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000050")]
internal class Contraction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000159")]
	public int Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400015A")]
	public readonly Char[] Source; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015B")]
	public readonly string Replacement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015C")]
	public readonly Byte[] SortKey; //Field offset: 0x28

	[Address(RVA = "0x1E5C210", Offset = "0x1E5B610", Length = "0x6F")]
	[Token(Token = "0x60000B1")]
	public Contraction(int index, Char[] source, string replacement, Byte[] sortkey) { }

}

