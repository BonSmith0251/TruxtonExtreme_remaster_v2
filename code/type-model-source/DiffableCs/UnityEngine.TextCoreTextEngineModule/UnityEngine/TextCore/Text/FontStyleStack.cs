namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200006B")]
internal struct FontStyleStack
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000464")]
	public byte bold; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000465")]
	public byte italic; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000466")]
	public byte underline; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000467")]
	public byte strikethrough; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000468")]
	public byte highlight; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000469")]
	public byte superscript; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400046A")]
	public byte subscript; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x400046B")]
	public byte uppercase; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400046C")]
	public byte lowercase; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x400046D")]
	public byte smallcaps; //Field offset: 0x9

	[Address(RVA = "0x2F19820", Offset = "0x2F18C20", Length = "0xA8")]
	[Token(Token = "0x600032C")]
	public byte Add(FontStyles style) { }

	[Address(RVA = "0x2F198D0", Offset = "0x2F18CD0", Length = "0xE")]
	[Token(Token = "0x600032B")]
	public void Clear() { }

	[Address(RVA = "0x2F198E0", Offset = "0x2F18CE0", Length = "0x128")]
	[Token(Token = "0x600032D")]
	public byte Remove(FontStyles style) { }

}

