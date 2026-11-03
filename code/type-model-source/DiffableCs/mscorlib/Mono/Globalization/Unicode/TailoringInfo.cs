namespace Mono.Globalization.Unicode;

[Token(Token = "0x200004F")]
internal class TailoringInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000155")]
	public readonly int LCID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000156")]
	public readonly int TailoringIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000157")]
	public readonly int TailoringCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000158")]
	public readonly bool FrenchSort; //Field offset: 0x1C

	[Address(RVA = "0x10AA910", Offset = "0x10A9D10", Length = "0x4C")]
	[Token(Token = "0x60000B0")]
	public TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort) { }

}

