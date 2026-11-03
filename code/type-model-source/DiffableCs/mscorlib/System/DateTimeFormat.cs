namespace System;

[Token(Token = "0x20000D9")]
internal static class DateTimeFormat
{
	[Token(Token = "0x40002FA")]
	internal static readonly TimeSpan NullOffset; //Field offset: 0x0
	[Token(Token = "0x40002FB")]
	internal static Char[] allStandardFormats; //Field offset: 0x8
	[Token(Token = "0x40002FC")]
	internal static readonly DateTimeFormatInfo InvariantFormatInfo; //Field offset: 0x10
	[Token(Token = "0x40002FD")]
	internal static readonly String[] InvariantAbbreviatedMonthNames; //Field offset: 0x18
	[Token(Token = "0x40002FE")]
	internal static readonly String[] InvariantAbbreviatedDayNames; //Field offset: 0x20
	[Token(Token = "0x40002FF")]
	internal static String[] fixedNumberFormats; //Field offset: 0x28

	[Address(RVA = "0x200AB40", Offset = "0x2009F40", Length = "0x366")]
	[Token(Token = "0x60006D3")]
	private static DateTimeFormat() { }

	[Address(RVA = "0x20066A0", Offset = "0x2005AA0", Length = "0x72")]
	[Token(Token = "0x60006C5")]
	private static void Append2DigitNumber(StringBuilder result, int val) { }

	[Address(RVA = "0x2006720", Offset = "0x2005B20", Length = "0x3D8")]
	[Token(Token = "0x60006C7")]
	private static string ExpandPredefinedFormat(ReadOnlySpan<Char> format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	[Address(RVA = "0x2008F70", Offset = "0x2008370", Length = "0x2E4")]
	[Token(Token = "0x60006C9")]
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset) { }

	[Address(RVA = "0x2008EE0", Offset = "0x20082E0", Length = "0x85")]
	[Token(Token = "0x60006C8")]
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider) { }

	[Address(RVA = "0x2007580", Offset = "0x2006980", Length = "0x1304")]
	[Token(Token = "0x60006C2")]
	private static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result) { }

	[Address(RVA = "0x2006DF0", Offset = "0x20061F0", Length = "0x313")]
	[Token(Token = "0x60006C4")]
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	[Address(RVA = "0x2007110", Offset = "0x2006510", Length = "0x464")]
	[Token(Token = "0x60006C3")]
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<Char> format, int tokenLen, bool timeOnly, StringBuilder result) { }

	[Address(RVA = "0x2008890", Offset = "0x2007C90", Length = "0x30")]
	[Token(Token = "0x60006BC")]
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x20088D0", Offset = "0x2007CD0", Length = "0x71")]
	[Token(Token = "0x60006B8")]
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	[Address(RVA = "0x2008950", Offset = "0x2007D50", Length = "0xF0")]
	[Token(Token = "0x60006B9")]
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	[Address(RVA = "0x2008A50", Offset = "0x2007E50", Length = "0xC3")]
	[Token(Token = "0x60006BE")]
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2008B20", Offset = "0x2007F20", Length = "0x30")]
	[Token(Token = "0x60006BD")]
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2008B60", Offset = "0x2007F60", Length = "0x360")]
	[Token(Token = "0x60006CC")]
	private static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	[Address(RVA = "0x2009260", Offset = "0x2008660", Length = "0x98")]
	[Token(Token = "0x60006C6")]
	internal static string GetRealFormat(ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x20095A0", Offset = "0x20089A0", Length = "0x6B")]
	[Token(Token = "0x60006BA")]
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60006D2")]
	internal static void InvalidFormatForLocal(ReadOnlySpan<Char> format, DateTime dateTime) { }

	[Address(RVA = "0x2009610", Offset = "0x2008A10", Length = "0x128")]
	[Token(Token = "0x60006C1")]
	private static bool IsUseGenitiveForm(ReadOnlySpan<Char> format, int index, int tokenLen, char patternToMatch) { }

	[Address(RVA = "0x2009740", Offset = "0x2008B40", Length = "0x65")]
	[Token(Token = "0x60006C0")]
	internal static int ParseNextChar(ReadOnlySpan<Char> format, int pos) { }

	[Address(RVA = "0x20097B0", Offset = "0x2008BB0", Length = "0x1E6")]
	[Token(Token = "0x60006BF")]
	internal static int ParseQuoteString(ReadOnlySpan<Char> format, int pos, StringBuilder result) { }

	[Address(RVA = "0x20099A0", Offset = "0x2008DA0", Length = "0x84")]
	[Token(Token = "0x60006BB")]
	internal static int ParseRepeatPattern(ReadOnlySpan<Char> format, int pos, char patternChar) { }

	[Address(RVA = "0x200A730", Offset = "0x2009B30", Length = "0xBE")]
	[Token(Token = "0x60006CA")]
	internal static bool TryFormat(DateTime dateTime, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x200A7F0", Offset = "0x2009BF0", Length = "0x22E")]
	[Token(Token = "0x60006CB")]
	internal static bool TryFormat(DateTime dateTime, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider, TimeSpan offset) { }

	[Address(RVA = "0x2009A30", Offset = "0x2008E30", Length = "0x79B")]
	[Token(Token = "0x60006CD")]
	private static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x200A1D0", Offset = "0x20095D0", Length = "0x55D")]
	[Token(Token = "0x60006CE")]
	private static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x200AA20", Offset = "0x2009E20", Length = "0xB0")]
	[Token(Token = "0x60006D1")]
	private static void WriteDigits(ulong value, Span<Char> buffer) { }

	[Address(RVA = "0x2005E40", Offset = "0x2005240", Length = "0x2A6")]
	[Token(Token = "0x60006D0")]
	private static void WriteFourDecimalDigits(uint value, Span<Char> buffer, int startingIndex = 0) { }

	[Address(RVA = "0x200AAE0", Offset = "0x2009EE0", Length = "0x57")]
	[Token(Token = "0x60006CF")]
	private static void WriteTwoDecimalDigits(uint value, Span<Char> destination, int offset) { }

}

