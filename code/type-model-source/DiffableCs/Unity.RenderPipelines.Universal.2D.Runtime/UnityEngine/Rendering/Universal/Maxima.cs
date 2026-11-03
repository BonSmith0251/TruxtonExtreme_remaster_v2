namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200001E")]
internal class Maxima
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000062")]
	internal long X; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000063")]
	internal Maxima Next; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000064")]
	internal Maxima Prev; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600003A")]
	public Maxima() { }

}

