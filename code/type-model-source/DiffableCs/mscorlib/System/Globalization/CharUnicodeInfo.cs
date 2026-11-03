namespace System.Globalization;

[Token(Token = "0x200053D")]
public static class CharUnicodeInfo
{

	[Token(Token = "0x17000538")]
	private static ReadOnlySpan<Byte> CategoriesValue
	{
		[Address(RVA = "0x1F4C9F0", Offset = "0x1F4BDF0", Length = "0x4C")]
		[Token(Token = "0x60025FD")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000535")]
	private static ReadOnlySpan<Byte> CategoryLevel1Index
	{
		[Address(RVA = "0x1F4CA40", Offset = "0x1F4BE40", Length = "0x4C")]
		[Token(Token = "0x60025FA")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000536")]
	private static ReadOnlySpan<Byte> CategoryLevel2Index
	{
		[Address(RVA = "0x1F4CA90", Offset = "0x1F4BE90", Length = "0x4C")]
		[Token(Token = "0x60025FB")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000537")]
	private static ReadOnlySpan<Byte> CategoryLevel3Index
	{
		[Address(RVA = "0x1F4CAE0", Offset = "0x1F4BEE0", Length = "0x4C")]
		[Token(Token = "0x60025FC")]
		private get { } //Length: 76
	}

	[Address(RVA = "0x1F4C9F0", Offset = "0x1F4BDF0", Length = "0x4C")]
	[Token(Token = "0x60025FD")]
	private static ReadOnlySpan<Byte> get_CategoriesValue() { }

	[Address(RVA = "0x1F4CA40", Offset = "0x1F4BE40", Length = "0x4C")]
	[Token(Token = "0x60025FA")]
	private static ReadOnlySpan<Byte> get_CategoryLevel1Index() { }

	[Address(RVA = "0x1F4CA90", Offset = "0x1F4BE90", Length = "0x4C")]
	[Token(Token = "0x60025FB")]
	private static ReadOnlySpan<Byte> get_CategoryLevel2Index() { }

	[Address(RVA = "0x1F4CAE0", Offset = "0x1F4BEE0", Length = "0x4C")]
	[Token(Token = "0x60025FC")]
	private static ReadOnlySpan<Byte> get_CategoryLevel3Index() { }

	[Address(RVA = "0x1F4C470", Offset = "0x1F4B870", Length = "0xA")]
	[Token(Token = "0x60025F1")]
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	[Address(RVA = "0x1F4C340", Offset = "0x1F4B740", Length = "0x124")]
	[Token(Token = "0x60025F2")]
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	[Address(RVA = "0x1F4C1E0", Offset = "0x1F4B5E0", Length = "0x158")]
	[Token(Token = "0x60025F3")]
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	[Address(RVA = "0x1F4C480", Offset = "0x1F4B880", Length = "0x97")]
	[Token(Token = "0x60025EF")]
	internal static int InternalConvertToUtf32(string s, int index) { }

	[Address(RVA = "0x1F4C520", Offset = "0x1F4B920", Length = "0x9F")]
	[Token(Token = "0x60025F0")]
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	[Address(RVA = "0x1F4C5C0", Offset = "0x1F4B9C0", Length = "0x166")]
	[Token(Token = "0x60025F4")]
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	[Address(RVA = "0x1F4C730", Offset = "0x1F4BB30", Length = "0x8F")]
	[Token(Token = "0x60025F5")]
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	[Address(RVA = "0x1F4C7C0", Offset = "0x1F4BBC0", Length = "0xA5")]
	[Token(Token = "0x60025F6")]
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	[Address(RVA = "0x1F4C870", Offset = "0x1F4BC70", Length = "0x12")]
	[Token(Token = "0x60025F7")]
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	[Address(RVA = "0x1F4C8B0", Offset = "0x1F4BCB0", Length = "0x132")]
	[Token(Token = "0x60025F8")]
	internal static bool IsWhiteSpace(string s, int index) { }

	[Address(RVA = "0x1F4C890", Offset = "0x1F4BC90", Length = "0x1C")]
	[Token(Token = "0x60025F9")]
	internal static bool IsWhiteSpace(char c) { }

}

