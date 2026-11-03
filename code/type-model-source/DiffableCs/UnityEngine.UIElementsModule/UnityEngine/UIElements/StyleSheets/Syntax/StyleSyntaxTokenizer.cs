namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x200064F")]
internal class StyleSyntaxTokenizer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017D2")]
	private List<StyleSyntaxToken> m_Tokens; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017D3")]
	private int m_CurrentTokenIndex; //Field offset: 0x18

	[Token(Token = "0x17000B60")]
	public StyleSyntaxToken current
	{
		[Address(RVA = "0x33724F0", Offset = "0x33718F0", Length = "0xE3")]
		[Token(Token = "0x6002CC5")]
		 get { } //Length: 227
	}

	[Address(RVA = "0x3372470", Offset = "0x3371870", Length = "0x7E")]
	[Token(Token = "0x6002CCD")]
	public StyleSyntaxTokenizer() { }

	[Address(RVA = "0x33724F0", Offset = "0x33718F0", Length = "0xE3")]
	[Token(Token = "0x6002CC5")]
	public StyleSyntaxToken get_current() { }

	[Address(RVA = "0x33714A0", Offset = "0x33708A0", Length = "0x5E")]
	[Token(Token = "0x6002CCC")]
	private static int GlobCharacter(string s, int index, char c) { }

	[Address(RVA = "0x3371500", Offset = "0x3370900", Length = "0x40")]
	[Token(Token = "0x6002CC9")]
	private static bool IsNextCharacter(string s, int index, char c) { }

	[Address(RVA = "0x3371550", Offset = "0x3370950", Length = "0xA5")]
	[Token(Token = "0x6002CCA")]
	private static bool IsNextLetterOrDash(string s, int index) { }

	[Address(RVA = "0x3371600", Offset = "0x3370A00", Length = "0x58")]
	[Token(Token = "0x6002CCB")]
	private static bool IsNextNumber(string s, int index) { }

	[Address(RVA = "0x3371660", Offset = "0x3370A60", Length = "0xC2")]
	[Token(Token = "0x6002CC6")]
	public StyleSyntaxToken MoveNext() { }

	[Address(RVA = "0x3371730", Offset = "0x3370B30", Length = "0xE3")]
	[Token(Token = "0x6002CC7")]
	public StyleSyntaxToken PeekNext() { }

	[Address(RVA = "0x3371820", Offset = "0x3370C20", Length = "0xC0C")]
	[Token(Token = "0x6002CC8")]
	public void Tokenize(string syntax) { }

}

