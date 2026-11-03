namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000E0")]
internal struct __DTString
{
	[Token(Token = "0x400034B")]
	private static readonly Char[] WhiteSpaceChecks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000346")]
	internal ReadOnlySpan<Char> Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000347")]
	internal int Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000348")]
	internal char m_current; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000349")]
	private CompareInfo m_info; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400034A")]
	private bool m_checkDigitToken; //Field offset: 0x20

	[Token(Token = "0x17000081")]
	internal CompareInfo CompareInfo
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600072D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000080")]
	internal int Length
	{
		[Address(RVA = "0x203C8B0", Offset = "0x203BCB0", Length = "0x2EA")]
		[Token(Token = "0x600072A")]
		internal get { } //Length: 746
	}

	[Address(RVA = "0x203C650", Offset = "0x203BA50", Length = "0x7E")]
	[Token(Token = "0x6000743")]
	private static __DTString() { }

	[Address(RVA = "0x203C6D0", Offset = "0x203BAD0", Length = "0xFA")]
	[Token(Token = "0x600072B")]
	internal __DTString(ReadOnlySpan<Char> str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	[Address(RVA = "0x203C7D0", Offset = "0x203BBD0", Length = "0xD0")]
	[Token(Token = "0x600072C")]
	internal __DTString(ReadOnlySpan<Char> str, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x203AA20", Offset = "0x2039E20", Length = "0x9A")]
	[Token(Token = "0x6000730")]
	internal bool Advance(int count) { }

	[Address(RVA = "0x203AAC0", Offset = "0x2039EC0", Length = "0x6E")]
	[Token(Token = "0x600072F")]
	internal bool AtEnd() { }

	[Address(RVA = "0x203AB30", Offset = "0x2039F30", Length = "0x9B")]
	[Token(Token = "0x6000742")]
	internal void ConsumeSubString(DTSubString sub) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600072D")]
	internal CompareInfo get_CompareInfo() { }

	[Address(RVA = "0x203C8B0", Offset = "0x203BCB0", Length = "0x2EA")]
	[Token(Token = "0x600072A")]
	internal int get_Length() { }

	[Address(RVA = "0x203ABD0", Offset = "0x2039FD0", Length = "0x1E")]
	[Token(Token = "0x600073A")]
	internal char GetChar() { }

	[Address(RVA = "0x203ABF0", Offset = "0x2039FF0", Length = "0x21")]
	[Token(Token = "0x600073B")]
	internal int GetDigit() { }

	[Address(RVA = "0x203ACE0", Offset = "0x203A0E0", Length = "0x9A")]
	[Token(Token = "0x600072E")]
	internal bool GetNext() { }

	[Address(RVA = "0x203AC20", Offset = "0x203A020", Length = "0xBE")]
	[Token(Token = "0x6000739")]
	internal bool GetNextDigit() { }

	[Address(RVA = "0x203AD80", Offset = "0x203A180", Length = "0x2F3")]
	[Token(Token = "0x6000731")]
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x203B080", Offset = "0x203A480", Length = "0xC0")]
	[Token(Token = "0x6000738")]
	internal int GetRepeatCount() { }

	[Address(RVA = "0x203B150", Offset = "0x203A550", Length = "0x21A")]
	[Token(Token = "0x6000732")]
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	[Address(RVA = "0x203B370", Offset = "0x203A770", Length = "0x157")]
	[Token(Token = "0x6000741")]
	internal DTSubString GetSubString() { }

	[Address(RVA = "0x203BBC0", Offset = "0x203AFC0", Length = "0x167")]
	[Token(Token = "0x6000735")]
	internal bool Match(string str) { }

	[Address(RVA = "0x203BD30", Offset = "0x203B130", Length = "0xB1")]
	[Token(Token = "0x6000736")]
	internal bool Match(char ch) { }

	[Address(RVA = "0x203B4D0", Offset = "0x203A8D0", Length = "0xEE")]
	[Token(Token = "0x6000737")]
	internal int MatchLongestWords(String[] words, ref int maxMatchStrLen) { }

	[Address(RVA = "0x203B5C0", Offset = "0x203A9C0", Length = "0x139")]
	[Token(Token = "0x6000733")]
	internal bool MatchSpecifiedWord(string target) { }

	[Address(RVA = "0x203B700", Offset = "0x203AB00", Length = "0x4B3")]
	[Token(Token = "0x6000734")]
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	[Address(RVA = "0x203BDF0", Offset = "0x203B1F0", Length = "0x2D1")]
	[Token(Token = "0x6000740")]
	internal void RemoveLeadingInQuoteSpaces() { }

	[Address(RVA = "0x203C0D0", Offset = "0x203B4D0", Length = "0x26B")]
	[Token(Token = "0x600073F")]
	internal void RemoveTrailingInQuoteSpaces() { }

	[Address(RVA = "0x203C340", Offset = "0x203B740", Length = "0x127")]
	[Token(Token = "0x600073D")]
	internal bool SkipWhiteSpaceCurrent() { }

	[Address(RVA = "0x203C470", Offset = "0x203B870", Length = "0xB8")]
	[Token(Token = "0x600073C")]
	internal void SkipWhiteSpaces() { }

	[Address(RVA = "0x203C530", Offset = "0x203B930", Length = "0x118")]
	[Token(Token = "0x600073E")]
	internal void TrimTail() { }

}

