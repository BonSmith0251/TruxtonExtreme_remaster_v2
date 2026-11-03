namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x200064C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleSyntaxParser
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017B5")]
	private List<Expression> m_ProcessExpressionList; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017B6")]
	private Stack<Expression> m_ExpressionStack; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017B7")]
	private Stack<ExpressionCombinator> m_CombinatorStack; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017B8")]
	private Dictionary<String, Expression> m_ParsedExpressionCache; //Field offset: 0x28

	[Address(RVA = "0x33712B0", Offset = "0x33706B0", Length = "0x149")]
	[Token(Token = "0x6002CC1")]
	public StyleSyntaxParser() { }

	[Address(RVA = "0x336EF20", Offset = "0x336E320", Length = "0x50")]
	[Token(Token = "0x6002CBD")]
	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	[Address(RVA = "0x336EF80", Offset = "0x336E380", Length = "0x14")]
	[Token(Token = "0x6002CBF")]
	private static bool IsCombinator(StyleSyntaxToken token) { }

	[Address(RVA = "0x336EFA0", Offset = "0x336E3A0", Length = "0x1E")]
	[Token(Token = "0x6002CBE")]
	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	[Address(RVA = "0x336EFC0", Offset = "0x336E3C0", Length = "0x21")]
	[Token(Token = "0x6002CC0")]
	private static bool IsMultiplier(StyleSyntaxToken token) { }

	[Address(RVA = "0x3370DA0", Offset = "0x33701A0", Length = "0x1A0")]
	[Token(Token = "0x6002CB1")]
	public Expression Parse(string syntax) { }

	[Address(RVA = "0x336EFF0", Offset = "0x336E3F0", Length = "0x24C")]
	[Token(Token = "0x6002CB5")]
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	[Address(RVA = "0x336F240", Offset = "0x336E640", Length = "0x6D3")]
	[Token(Token = "0x6002CB7")]
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	[Address(RVA = "0x336F920", Offset = "0x336ED20", Length = "0x294")]
	[Token(Token = "0x6002CB2")]
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	[Address(RVA = "0x336FBC0", Offset = "0x336EFC0", Length = "0x2F7")]
	[Token(Token = "0x6002CB6")]
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	[Address(RVA = "0x336FEC0", Offset = "0x336F2C0", Length = "0x2C1")]
	[Token(Token = "0x6002CBB")]
	private void ParseLimits(StyleSyntaxTokenizer tokenizer, out float min, out float max) { }

	[Address(RVA = "0x3370190", Offset = "0x336F590", Length = "0x280")]
	[Token(Token = "0x6002CBA")]
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) { }

	[Address(RVA = "0x3370430", Offset = "0x336F830", Length = "0x1A3")]
	[Token(Token = "0x6002CB8")]
	private Expression ParseNonTerminalValue(string syntax) { }

	[Address(RVA = "0x33705E0", Offset = "0x336F9E0", Length = "0x4A5")]
	[Token(Token = "0x6002CB9")]
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	[Address(RVA = "0x3370A90", Offset = "0x336FE90", Length = "0x15E")]
	[Token(Token = "0x6002CBC")]
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) { }

	[Address(RVA = "0x3370BF0", Offset = "0x336FFF0", Length = "0x1A2")]
	[Token(Token = "0x6002CB4")]
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	[Address(RVA = "0x3370F50", Offset = "0x3370350", Length = "0x35A")]
	[Token(Token = "0x6002CB3")]
	private void ProcessCombinatorStack() { }

}

