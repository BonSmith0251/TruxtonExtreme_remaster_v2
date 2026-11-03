namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x200064E")]
internal struct StyleSyntaxToken
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017CF")]
	public StyleSyntaxTokenType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40017D0")]
	public string text; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017D1")]
	public float number; //Field offset: 0x10

	[Address(RVA = "0x3371440", Offset = "0x3370840", Length = "0x2B")]
	[Token(Token = "0x6002CC2")]
	public StyleSyntaxToken(StyleSyntaxTokenType t) { }

	[Address(RVA = "0x3371470", Offset = "0x3370870", Length = "0x28")]
	[Token(Token = "0x6002CC3")]
	public StyleSyntaxToken(StyleSyntaxTokenType type, string text) { }

	[Address(RVA = "0x3371400", Offset = "0x3370800", Length = "0x36")]
	[Token(Token = "0x6002CC4")]
	public StyleSyntaxToken(StyleSyntaxTokenType type, float number) { }

}

