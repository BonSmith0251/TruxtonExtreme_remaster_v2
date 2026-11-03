namespace System.IO.Enumeration;

[Token(Token = "0x2000691")]
public static class FileSystemName
{
	[Token(Token = "0x4001A7A")]
	private static readonly Char[] s_wildcardChars; //Field offset: 0x0
	[Token(Token = "0x4001A7B")]
	private static readonly Char[] s_simpleWildcardChars; //Field offset: 0x8

	[Address(RVA = "0x1FF7AB0", Offset = "0x1FF6EB0", Length = "0xF1")]
	[Token(Token = "0x6003159")]
	private static FileSystemName() { }

	[Address(RVA = "0x1FF7670", Offset = "0x1FF6A70", Length = "0x89")]
	[Token(Token = "0x6003157")]
	public static bool MatchesSimpleExpression(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase = true) { }

	[Address(RVA = "0x1FF7700", Offset = "0x1FF6B00", Length = "0x89")]
	[Token(Token = "0x6003156")]
	public static bool MatchesWin32Expression(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase = true) { }

	[Address(RVA = "0x1FF6D30", Offset = "0x1FF6130", Length = "0x935")]
	[Token(Token = "0x6003158")]
	private static bool MatchPattern(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase, bool useExtendedWildcards) { }

	[Address(RVA = "0x1FF7790", Offset = "0x1FF6B90", Length = "0x31D")]
	[Token(Token = "0x6003155")]
	public static string TranslateWin32Expression(string expression) { }

}

