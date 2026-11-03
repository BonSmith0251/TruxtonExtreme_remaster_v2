namespace System.Globalization;

[Token(Token = "0x200000A")]
internal class FormatProvider
{
	[Token(Token = "0x200000B")]
	private class Number
	{
		[Token(Token = "0x200000C")]
		public struct NumberBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400001C")]
			public int precision; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400001D")]
			public int scale; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400001E")]
			public bool sign; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400001F")]
			public Char* overrideDigits; //Field offset: 0x10

			[Token(Token = "0x17000004")]
			public Char* digits
			{
				[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
				[Token(Token = "0x600008D")]
				 get { } //Length: 5
			}

			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x600008D")]
			public Char* get_digits() { }

		}

		[Token(Token = "0x4000016")]
		private static String[] s_posCurrencyFormats; //Field offset: 0x0
		[Token(Token = "0x4000017")]
		private static String[] s_negCurrencyFormats; //Field offset: 0x8
		[Token(Token = "0x4000018")]
		private static String[] s_posPercentFormats; //Field offset: 0x10
		[Token(Token = "0x4000019")]
		private static String[] s_negPercentFormats; //Field offset: 0x18
		[Token(Token = "0x400001A")]
		private static String[] s_negNumberFormats; //Field offset: 0x20
		[Token(Token = "0x400001B")]
		private static string s_posNumberFormat; //Field offset: 0x28

		[Address(RVA = "0x23EC0F0", Offset = "0x23EB4F0", Length = "0x8BB")]
		[Token(Token = "0x600008C")]
		private static Number() { }

		[Address(RVA = "0x23E88A0", Offset = "0x23E7CA0", Length = "0x117")]
		[Token(Token = "0x600008A")]
		private static int FindSection(ReadOnlySpan<Char> format, int section) { }

		[Address(RVA = "0x23E89C0", Offset = "0x23E7DC0", Length = "0x218")]
		[Token(Token = "0x6000081")]
		private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[Address(RVA = "0x23E8BE0", Offset = "0x23E7FE0", Length = "0x1D7")]
		[Token(Token = "0x6000086")]
		private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

		[Address(RVA = "0x23E8DC0", Offset = "0x23E81C0", Length = "0x4CB")]
		[Token(Token = "0x6000083")]
		private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

		[Address(RVA = "0x23E9290", Offset = "0x23E8690", Length = "0x311")]
		[Token(Token = "0x6000087")]
		private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

		[Address(RVA = "0x23E95B0", Offset = "0x23E89B0", Length = "0x1DC")]
		[Token(Token = "0x6000084")]
		private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[Address(RVA = "0x23E9790", Offset = "0x23E8B90", Length = "0x222")]
		[Token(Token = "0x6000088")]
		private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[Address(RVA = "0x23E99C0", Offset = "0x23E8DC0", Length = "0x176")]
		[Token(Token = "0x6000085")]
		private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

		[Address(RVA = "0x23E9B40", Offset = "0x23E8F40", Length = "0x65")]
		[Token(Token = "0x600007E")]
		internal static void Int32ToDecChars(Char* buffer, ref int index, uint value, int digits) { }

		[Address(RVA = "0x23E9BB0", Offset = "0x23E8FB0", Length = "0x1A")]
		[Token(Token = "0x6000078")]
		private static bool IsWhite(char ch) { }

		[Address(RVA = "0x23E9BD0", Offset = "0x23E8FD0", Length = "0x49")]
		[Token(Token = "0x600007A")]
		private static Char* MatchChars(Char* p, Char* pEnd, Char* str) { }

		[Address(RVA = "0x23E9C20", Offset = "0x23E9020", Length = "0xBF")]
		[Token(Token = "0x6000079")]
		private static Char* MatchChars(Char* p, Char* pEnd, string str) { }

		[Address(RVA = "0x23EAA90", Offset = "0x23E9E90", Length = "0x6CD")]
		[Token(Token = "0x6000080")]
		internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

		[Address(RVA = "0x23E9CE0", Offset = "0x23E90E0", Length = "0x968")]
		[Token(Token = "0x600008B")]
		internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

		[Address(RVA = "0x23EB160", Offset = "0x23EA560", Length = "0x191")]
		[Token(Token = "0x600007F")]
		internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

		[Address(RVA = "0x23EB300", Offset = "0x23EA700", Length = "0xAE9")]
		[Token(Token = "0x600007B")]
		private static bool ParseNumber(ref Char* str, Char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		[Address(RVA = "0x23EBDF0", Offset = "0x23EB1F0", Length = "0xE5")]
		[Token(Token = "0x6000089")]
		private static void RoundNumber(ref NumberBuffer number, int pos) { }

		[Address(RVA = "0x23EBEE0", Offset = "0x23EB2E0", Length = "0x77")]
		[Token(Token = "0x600007C")]
		private static bool TrailingZeros(ReadOnlySpan<Char> s, int index) { }

		[Address(RVA = "0x23EBF60", Offset = "0x23EB360", Length = "0x18F")]
		[Token(Token = "0x600007D")]
		internal static bool TryStringToNumber(ReadOnlySpan<Char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		[Address(RVA = "0x23EC9B0", Offset = "0x23EBDB0", Length = "0x20")]
		[Token(Token = "0x6000082")]
		private static int wcslen(Char* s) { }

	}


	[Address(RVA = "0x23E84F0", Offset = "0x23E78F0", Length = "0x16B")]
	[Token(Token = "0x6000076")]
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	[Address(RVA = "0x23E8660", Offset = "0x23E7A60", Length = "0x234")]
	[Token(Token = "0x6000077")]
	internal static bool TryStringToBigInteger(ReadOnlySpan<Char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}

