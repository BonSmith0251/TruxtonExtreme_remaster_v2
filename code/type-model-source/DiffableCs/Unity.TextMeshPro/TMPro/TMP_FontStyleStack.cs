namespace TMPro;

[Token(Token = "0x20000B3")]
public struct TMP_FontStyleStack
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400066C")]
	public byte bold; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400066D")]
	public byte italic; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400066E")]
	public byte underline; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x400066F")]
	public byte strikethrough; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000670")]
	public byte highlight; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000671")]
	public byte superscript; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000672")]
	public byte subscript; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x4000673")]
	public byte uppercase; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000674")]
	public byte lowercase; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000675")]
	public byte smallcaps; //Field offset: 0x9

	[Address(RVA = "0x2F19820", Offset = "0x2F18C20", Length = "0xA8")]
	[Token(Token = "0x60006CF")]
	public byte Add(FontStyles style) { }

	[Address(RVA = "0x2F198D0", Offset = "0x2F18CD0", Length = "0xE")]
	[Token(Token = "0x60006CE")]
	public void Clear() { }

	[Address(RVA = "0x2F198E0", Offset = "0x2F18CE0", Length = "0x128")]
	[Token(Token = "0x60006D0")]
	public byte Remove(FontStyles style) { }

}

