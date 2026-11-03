namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E0")]
internal sealed class ExclusiveReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400036D")]
	private RegexRunner _ref; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400036E")]
	private RegexRunner _obj; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400036F")]
	private int _locked; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60004E0")]
	public ExclusiveReference() { }

	[Address(RVA = "0x2616430", Offset = "0x2615830", Length = "0x70")]
	[Token(Token = "0x60004DE")]
	public RegexRunner Get() { }

	[Address(RVA = "0x26164A0", Offset = "0x26158A0", Length = "0xD4")]
	[Token(Token = "0x60004DF")]
	public void Release(RegexRunner obj) { }

}

