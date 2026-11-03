namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000F0")]
internal static class StringUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20000F2")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x0")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1})]
		[Token(Token = "0x40004D4")]
		public Func<TSource, String> valueSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Nullable(0)]
		[Token(Token = "0x40004D5")]
		public string testValue; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000717")]
		public <>c__DisplayClass14_0`1() { }

		[Address(RVA = "0xA53E70", Offset = "0xA53270", Length = "0x3F")]
		[NullableContext(0)]
		[Token(Token = "0x6000718")]
		internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

		[Address(RVA = "0xA53FB0", Offset = "0xA533B0", Length = "0x3F")]
		[NullableContext(0)]
		[Token(Token = "0x6000719")]
		internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

	}

	[NullableContext(0)]
	[Token(Token = "0x20000F1")]
	private enum SeparatedCaseState : int
	{
		Start = 0,
		Lower = 1,
		Upper = 2,
		NewWord = 3,
	}

	[Token(Token = "0x40004CA")]
	public const string CarriageReturnLineFeed = "
"; //Field offset: 0x0
	[Token(Token = "0x40004CB")]
	public const string Empty = ""; //Field offset: 0x0
	[Token(Token = "0x40004CC")]
	public const char CarriageReturn = '\uD'; //Field offset: 0x0
	[Token(Token = "0x40004CD")]
	public const char LineFeed = '\uA'; //Field offset: 0x0
	[Token(Token = "0x40004CE")]
	public const char Tab = '\u9'; //Field offset: 0x0

	[Address(RVA = "0x2152B40", Offset = "0x2151F40", Length = "0xB3")]
	[Token(Token = "0x6000708")]
	public static StringWriter CreateStringWriter(int capacity) { }

	[Address(RVA = "0x2152C00", Offset = "0x2152000", Length = "0x3A")]
	[Extension]
	[Token(Token = "0x6000715")]
	public static bool EndsWith(string source, char value) { }

	[Address(RVA = "0x9161A0", Offset = "0x9155A0", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600070A")]
	public static TSource ForgivingCaseSensitiveFind(IEnumerable<TSource> source, Func<TSource, String> valueSelector, string testValue) { }

	[Address(RVA = "0x2153100", Offset = "0x2152500", Length = "0x126")]
	[Extension]
	[Token(Token = "0x6000702")]
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Address(RVA = "0x2153230", Offset = "0x2152630", Length = "0x188")]
	[Extension]
	[Token(Token = "0x6000703")]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Address(RVA = "0x2152F20", Offset = "0x2152320", Length = "0x1D4")]
	[Extension]
	[Token(Token = "0x6000704")]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[Address(RVA = "0x2152CF0", Offset = "0x21520F0", Length = "0x220")]
	[Extension]
	[NullableContext(2)]
	[Token(Token = "0x6000705")]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Address(RVA = "0x2152C40", Offset = "0x2152040", Length = "0xA6")]
	[Extension]
	[Token(Token = "0x6000706")]
	private static string FormatWith(string format, IFormatProvider provider, Object[] args) { }

	[Address(RVA = "0x21533C0", Offset = "0x21527C0", Length = "0x1A")]
	[Token(Token = "0x6000712")]
	public static int IndexOf(string s, char c) { }

	[Address(RVA = "0x21533E0", Offset = "0x21527E0", Length = "0x2D")]
	[Token(Token = "0x6000710")]
	public static bool IsHighSurrogate(char c) { }

	[Address(RVA = "0x2153410", Offset = "0x2152810", Length = "0x2D")]
	[Token(Token = "0x6000711")]
	public static bool IsLowSurrogate(char c) { }

	[Address(RVA = "0x2153440", Offset = "0x2152840", Length = "0x7")]
	[NullableContext(2)]
	[Token(Token = "0x6000701")]
	public static bool IsNullOrEmpty(string value) { }

	[Address(RVA = "0x2153450", Offset = "0x2152850", Length = "0xC9")]
	[Token(Token = "0x6000707")]
	public static bool IsWhiteSpace(string s) { }

	[Address(RVA = "0x2153520", Offset = "0x2152920", Length = "0x1A")]
	[Token(Token = "0x6000713")]
	public static string Replace(string s, string oldValue, string newValue) { }

	[Address(RVA = "0x2153540", Offset = "0x2152940", Length = "0x37")]
	[Extension]
	[Token(Token = "0x6000714")]
	public static bool StartsWith(string source, char value) { }

	[Address(RVA = "0x2153580", Offset = "0x2152980", Length = "0x1C8")]
	[Token(Token = "0x600070B")]
	public static string ToCamelCase(string s) { }

	[Address(RVA = "0x2153750", Offset = "0x2152B50", Length = "0xAC")]
	[Token(Token = "0x6000709")]
	public static void ToCharAsUnicode(char c, Char[] buffer) { }

	[Address(RVA = "0x2153800", Offset = "0x2152C00", Length = "0xD")]
	[Token(Token = "0x600070E")]
	public static string ToKebabCase(string s) { }

	[Address(RVA = "0x2153810", Offset = "0x2152C10", Length = "0x75")]
	[Token(Token = "0x600070C")]
	private static char ToLower(char c) { }

	[Address(RVA = "0x2153890", Offset = "0x2152C90", Length = "0x2C8")]
	[Token(Token = "0x600070F")]
	private static string ToSeparatedCase(string s, char separator) { }

	[Address(RVA = "0x2153B60", Offset = "0x2152F60", Length = "0xD")]
	[Token(Token = "0x600070D")]
	public static string ToSnakeCase(string s) { }

	[Address(RVA = "0x2153B70", Offset = "0x2152F70", Length = "0x203")]
	[Extension]
	[Token(Token = "0x6000716")]
	public static string Trim(string s, int start, int length) { }

}

