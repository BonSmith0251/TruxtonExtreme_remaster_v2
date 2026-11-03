namespace System;

[Token(Token = "0x200011C")]
internal static class Number
{
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200011D")]
	public struct NumberBuffer
	{
		[Token(Token = "0x200011E")]
		private struct DigitsAndNullTerminator
		{

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041E")]
		public int precision; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400041F")]
		public int scale; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000420")]
		private int _sign; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000421")]
		private DigitsAndNullTerminator _digits; //Field offset: 0xC
		[FieldOffset(Offset = "0x72")]
		[Token(Token = "0x4000422")]
		private Char* _allDigits; //Field offset: 0x72

		[Token(Token = "0x17000091")]
		public Char* digits
		{
			[Address(RVA = "0x2043710", Offset = "0x2042B10", Length = "0x5")]
			[Token(Token = "0x6000942")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000090")]
		public bool sign
		{
			[Address(RVA = "0x2043720", Offset = "0x2042B20", Length = "0x8")]
			[Token(Token = "0x6000940")]
			 get { } //Length: 8
			[Address(RVA = "0x2043730", Offset = "0x2042B30", Length = "0x9")]
			[Token(Token = "0x6000941")]
			 set { } //Length: 9
		}

		[Address(RVA = "0x2043710", Offset = "0x2042B10", Length = "0x5")]
		[Token(Token = "0x6000942")]
		public Char* get_digits() { }

		[Address(RVA = "0x2043720", Offset = "0x2042B20", Length = "0x8")]
		[Token(Token = "0x6000940")]
		public bool get_sign() { }

		[Address(RVA = "0x2043730", Offset = "0x2042B30", Length = "0x9")]
		[Token(Token = "0x6000941")]
		public void set_sign(bool value) { }

	}

	[Token(Token = "0x4000414")]
	private static readonly String[] s_posCurrencyFormats; //Field offset: 0x0
	[Token(Token = "0x4000415")]
	private static readonly String[] s_negCurrencyFormats; //Field offset: 0x8
	[Token(Token = "0x4000416")]
	private static readonly String[] s_posPercentFormats; //Field offset: 0x10
	[Token(Token = "0x4000417")]
	private static readonly String[] s_negPercentFormats; //Field offset: 0x18
	[Token(Token = "0x4000418")]
	private static readonly String[] s_negNumberFormats; //Field offset: 0x20
	[Token(Token = "0x4000419")]
	private static readonly Int32[] s_charToHexLookup; //Field offset: 0x28
	[Token(Token = "0x400041A")]
	private static readonly UInt64[] s_rgval64Power10; //Field offset: 0x30
	[Token(Token = "0x400041B")]
	private static readonly SByte[] s_rgexp64Power10; //Field offset: 0x38
	[Token(Token = "0x400041C")]
	private static readonly UInt64[] s_rgval64Power10By16; //Field offset: 0x40
	[Token(Token = "0x400041D")]
	private static readonly Int16[] s_rgexp64Power10By16; //Field offset: 0x48

	[Address(RVA = "0x2039E10", Offset = "0x2039210", Length = "0xA82")]
	[Token(Token = "0x600093F")]
	private static Number() { }

	[Address(RVA = "0x203A8A0", Offset = "0x2039CA0", Length = "0x8")]
	[Token(Token = "0x600093C")]
	private static int abs(int value) { }

	[Address(RVA = "0x202D0C0", Offset = "0x202C4C0", Length = "0x1EC")]
	[Token(Token = "0x60008E6")]
	private static void DecimalToNumber(decimal value, ref NumberBuffer number) { }

	[Address(RVA = "0x202D2B0", Offset = "0x202C6B0", Length = "0x36")]
	[Token(Token = "0x6000939")]
	private static uint DigitsToInt(Char* p, int count) { }

	[Address(RVA = "0x202D2F0", Offset = "0x202C6F0", Length = "0x143")]
	[Token(Token = "0x600093E")]
	private static void DoubleToNumber(double value, int precision, ref NumberBuffer number) { }

	[Address(RVA = "0x202D440", Offset = "0x202C840", Length = "0x117")]
	[Token(Token = "0x6000913")]
	private static int FindSection(ReadOnlySpan<Char> format, int section) { }

	[Address(RVA = "0x202D560", Offset = "0x202C960", Length = "0x217")]
	[Token(Token = "0x600090B")]
	private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	[Address(RVA = "0x202D780", Offset = "0x202CB80", Length = "0x200")]
	[Token(Token = "0x60008E4")]
	public static string FormatDecimal(decimal value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[Address(RVA = "0x202D980", Offset = "0x202CD80", Length = "0x140")]
	[Token(Token = "0x60008E7")]
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	[Address(RVA = "0x202DAC0", Offset = "0x202CEC0", Length = "0x309")]
	[Token(Token = "0x60008E9")]
	private static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[Address(RVA = "0x202DDD0", Offset = "0x202D1D0", Length = "0x16F")]
	[Token(Token = "0x600090F")]
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	[Address(RVA = "0x202DF40", Offset = "0x202D340", Length = "0x506")]
	[Token(Token = "0x600090C")]
	private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

	[Address(RVA = "0x202E450", Offset = "0x202D850", Length = "0x331")]
	[Token(Token = "0x6000910")]
	private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	[Address(RVA = "0x202E790", Offset = "0x202DB90", Length = "0x310")]
	[Token(Token = "0x60008EE")]
	public static string FormatInt32(int value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x202EAB0", Offset = "0x202DEB0", Length = "0x317")]
	[Token(Token = "0x60008F2")]
	public static string FormatInt64(long value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x202EDD0", Offset = "0x202E1D0", Length = "0x1D2")]
	[Token(Token = "0x600090D")]
	private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	[Address(RVA = "0x202EFB0", Offset = "0x202E3B0", Length = "0x224")]
	[Token(Token = "0x6000911")]
	private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	[Address(RVA = "0x202F1E0", Offset = "0x202E5E0", Length = "0x17E")]
	[Token(Token = "0x600090E")]
	private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	[Address(RVA = "0x202F360", Offset = "0x202E760", Length = "0x140")]
	[Token(Token = "0x60008EA")]
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	[Address(RVA = "0x202F4A0", Offset = "0x202E8A0", Length = "0x31B")]
	[Token(Token = "0x60008EC")]
	private static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[Address(RVA = "0x202F7C0", Offset = "0x202EBC0", Length = "0x2BD")]
	[Token(Token = "0x60008F0")]
	public static string FormatUInt32(uint value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x202FA80", Offset = "0x202EE80", Length = "0x2C1")]
	[Token(Token = "0x60008F4")]
	public static string FormatUInt64(ulong value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x202FD50", Offset = "0x202F150", Length = "0x7")]
	[Token(Token = "0x6000915")]
	private static uint High32(ulong value) { }

	[Address(RVA = "0x202FD60", Offset = "0x202F160", Length = "0x42")]
	[Token(Token = "0x60008FB")]
	private static Char* Int32ToHexChars(Char* buffer, uint value, int hexBase, int digits) { }

	[Address(RVA = "0x202FDB0", Offset = "0x202F1B0", Length = "0x12F")]
	[Token(Token = "0x60008F9")]
	private static string Int32ToHexStr(int value, char hexBase, int digits) { }

	[Address(RVA = "0x202FEE0", Offset = "0x202F2E0", Length = "0x10C")]
	[Token(Token = "0x60008F6")]
	private static void Int32ToNumber(int value, ref NumberBuffer number) { }

	[Address(RVA = "0x202FFF0", Offset = "0x202F3F0", Length = "0x49")]
	[Token(Token = "0x6000916")]
	private static uint Int64DivMod1E9(ref ulong value) { }

	[Address(RVA = "0x2030040", Offset = "0x202F440", Length = "0x1FC")]
	[Token(Token = "0x6000903")]
	private static string Int64ToHexStr(long value, char hexBase, int digits) { }

	[Address(RVA = "0x2030240", Offset = "0x202F640", Length = "0x1CC")]
	[Token(Token = "0x6000900")]
	private static void Int64ToNumber(long input, ref NumberBuffer number) { }

	[Address(RVA = "0x2030410", Offset = "0x202F810", Length = "0xA")]
	[Token(Token = "0x6000936")]
	private static bool IsDigit(int ch) { }

	[Address(RVA = "0x2030420", Offset = "0x202F820", Length = "0x12")]
	[Token(Token = "0x6000935")]
	private static bool IsWhite(int ch) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000914")]
	private static uint Low32(ulong value) { }

	[Address(RVA = "0x2030440", Offset = "0x202F840", Length = "0x8F")]
	[Token(Token = "0x6000934")]
	private static Char* MatchChars(Char* p, Char* pEnd, string value) { }

	[Address(RVA = "0x20304D0", Offset = "0x202F8D0", Length = "0x9")]
	[Token(Token = "0x600093A")]
	private static ulong Mul32x32To64(uint a, uint b) { }

	[Address(RVA = "0x20304E0", Offset = "0x202F8E0", Length = "0x8C")]
	[Token(Token = "0x600093B")]
	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) { }

	[Address(RVA = "0x2030570", Offset = "0x202F970", Length = "0x193")]
	[Token(Token = "0x60008F7")]
	private static string NegativeInt32ToDecStr(int value, int digits, string sNegative) { }

	[Address(RVA = "0x2030710", Offset = "0x202FB10", Length = "0x1F3")]
	[Token(Token = "0x6000901")]
	private static string NegativeInt64ToDecStr(long input, int digits, string sNegative) { }

	[Address(RVA = "0x2030910", Offset = "0x202FD10", Length = "0x2B7")]
	[Token(Token = "0x600092B")]
	private static bool NumberBufferToDecimal(ref NumberBuffer number, ref decimal value) { }

	[Address(RVA = "0x2030BD0", Offset = "0x202FFD0", Length = "0x9F")]
	[Token(Token = "0x6000938")]
	private static bool NumberBufferToDouble(ref NumberBuffer number, ref double value) { }

	[Address(RVA = "0x2030C70", Offset = "0x2030070", Length = "0x660")]
	[Token(Token = "0x600093D")]
	private static double NumberToDouble(ref NumberBuffer number) { }

	[Address(RVA = "0x20312E0", Offset = "0x20306E0", Length = "0x9C")]
	[Token(Token = "0x6000917")]
	private static bool NumberToInt32(ref NumberBuffer number, ref int value) { }

	[Address(RVA = "0x2031380", Offset = "0x2030780", Length = "0xA3")]
	[Token(Token = "0x6000918")]
	private static bool NumberToInt64(ref NumberBuffer number, ref long value) { }

	[Address(RVA = "0x20320F0", Offset = "0x20314F0", Length = "0x6E9")]
	[Token(Token = "0x6000909")]
	internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	[Address(RVA = "0x2031430", Offset = "0x2030830", Length = "0xC8C")]
	[Token(Token = "0x600090A")]
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[Address(RVA = "0x20327E0", Offset = "0x2031BE0", Length = "0x9B")]
	[Token(Token = "0x6000919")]
	private static bool NumberToUInt32(ref NumberBuffer number, ref uint value) { }

	[Address(RVA = "0x2032880", Offset = "0x2031C80", Length = "0xA5")]
	[Token(Token = "0x600091A")]
	private static bool NumberToUInt64(ref NumberBuffer number, ref ulong value) { }

	[Address(RVA = "0x2032930", Offset = "0x2031D30", Length = "0x11B")]
	[Token(Token = "0x600092A")]
	internal static decimal ParseDecimal(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[Address(RVA = "0x2032A50", Offset = "0x2031E50", Length = "0x42E")]
	[Token(Token = "0x600092C")]
	internal static double ParseDouble(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[Address(RVA = "0x2032E80", Offset = "0x2032280", Length = "0x191")]
	[Token(Token = "0x6000908")]
	internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

	[Address(RVA = "0x2033020", Offset = "0x2032420", Length = "0x23E")]
	[Token(Token = "0x600091B")]
	internal static int ParseInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[Address(RVA = "0x2033260", Offset = "0x2032660", Length = "0x252")]
	[Token(Token = "0x600091C")]
	internal static long ParseInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[Address(RVA = "0x20334C0", Offset = "0x20328C0", Length = "0xB61")]
	[Token(Token = "0x600091F")]
	private static bool ParseNumber(ref Char* str, Char* strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	[Address(RVA = "0x2034030", Offset = "0x2033430", Length = "0x45B")]
	[Token(Token = "0x600092D")]
	internal static float ParseSingle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[Address(RVA = "0x2034490", Offset = "0x2033890", Length = "0x235")]
	[Token(Token = "0x600091D")]
	internal static uint ParseUInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[Address(RVA = "0x20346D0", Offset = "0x2033AD0", Length = "0x244")]
	[Token(Token = "0x600091E")]
	internal static ulong ParseUInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[Address(RVA = "0x2034920", Offset = "0x2033D20", Length = "0xEE")]
	[Token(Token = "0x6000912")]
	private static void RoundNumber(ref NumberBuffer number, int pos) { }

	[Address(RVA = "0x2034A10", Offset = "0x2033E10", Length = "0x191")]
	[Token(Token = "0x6000931")]
	private static void StringToNumber(ReadOnlySpan<Char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	[Address(RVA = "0x2034BB0", Offset = "0x2033FB0", Length = "0x93")]
	[Token(Token = "0x6000937")]
	private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey) { }

	[Address(RVA = "0x2034C50", Offset = "0x2034050", Length = "0x77")]
	[Token(Token = "0x6000933")]
	private static bool TrailingZeros(ReadOnlySpan<Char> value, int index) { }

	[Address(RVA = "0x2034CD0", Offset = "0x20340D0", Length = "0xE4")]
	[Token(Token = "0x60008ED")]
	private static bool TryCopyTo(string source, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2034DC0", Offset = "0x20341C0", Length = "0x210")]
	[Token(Token = "0x60008E5")]
	public static bool TryFormatDecimal(decimal value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2034FD0", Offset = "0x20343D0", Length = "0x1BE")]
	[Token(Token = "0x60008E8")]
	public static bool TryFormatDouble(double value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2035190", Offset = "0x2034590", Length = "0x38A")]
	[Token(Token = "0x60008EF")]
	public static bool TryFormatInt32(int value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2035520", Offset = "0x2034920", Length = "0x391")]
	[Token(Token = "0x60008F3")]
	public static bool TryFormatInt64(long value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x20358C0", Offset = "0x2034CC0", Length = "0x1BE")]
	[Token(Token = "0x60008EB")]
	public static bool TryFormatSingle(float value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2035A80", Offset = "0x2034E80", Length = "0x306")]
	[Token(Token = "0x60008F1")]
	public static bool TryFormatUInt32(uint value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2035D90", Offset = "0x2035190", Length = "0x306")]
	[Token(Token = "0x60008F5")]
	public static bool TryFormatUInt64(ulong value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x20360A0", Offset = "0x20354A0", Length = "0x14E")]
	[Token(Token = "0x60008FA")]
	private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x20361F0", Offset = "0x20355F0", Length = "0x232")]
	[Token(Token = "0x6000904")]
	private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2036430", Offset = "0x2035830", Length = "0x1AE")]
	[Token(Token = "0x60008F8")]
	private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x20365E0", Offset = "0x20359E0", Length = "0x21D")]
	[Token(Token = "0x6000902")]
	private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2036800", Offset = "0x2035C00", Length = "0x10D")]
	[Token(Token = "0x600092E")]
	internal static bool TryParseDecimal(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out decimal result) { }

	[Address(RVA = "0x2036910", Offset = "0x2035D10", Length = "0x174")]
	[Token(Token = "0x600092F")]
	internal static bool TryParseDouble(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out double result) { }

	[Address(RVA = "0x20370D0", Offset = "0x20364D0", Length = "0x1BF")]
	[Token(Token = "0x6000920")]
	internal static bool TryParseInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out int result) { }

	[Address(RVA = "0x2036A90", Offset = "0x2035E90", Length = "0x633")]
	[Token(Token = "0x6000921")]
	private static bool TryParseInt32IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow) { }

	[Address(RVA = "0x20378E0", Offset = "0x2036CE0", Length = "0x1C0")]
	[Token(Token = "0x6000923")]
	internal static bool TryParseInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out long result) { }

	[Address(RVA = "0x2037290", Offset = "0x2036690", Length = "0x647")]
	[Token(Token = "0x6000922")]
	private static bool TryParseInt64IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow) { }

	[Address(RVA = "0x2037AA0", Offset = "0x2036EA0", Length = "0x182")]
	[Token(Token = "0x6000930")]
	internal static bool TryParseSingle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out float result) { }

	[Address(RVA = "0x20385A0", Offset = "0x20379A0", Length = "0x1C2")]
	[Token(Token = "0x6000924")]
	internal static bool TryParseUInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result) { }

	[Address(RVA = "0x2037C30", Offset = "0x2037030", Length = "0x372")]
	[Token(Token = "0x6000926")]
	private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	[Address(RVA = "0x2037FB0", Offset = "0x20373B0", Length = "0x5E6")]
	[Token(Token = "0x6000925")]
	private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	[Address(RVA = "0x20390F0", Offset = "0x20384F0", Length = "0x1C3")]
	[Token(Token = "0x6000927")]
	internal static bool TryParseUInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result) { }

	[Address(RVA = "0x2038770", Offset = "0x2037B70", Length = "0x372")]
	[Token(Token = "0x6000929")]
	private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	[Address(RVA = "0x2038AF0", Offset = "0x2037EF0", Length = "0x5F7")]
	[Token(Token = "0x6000928")]
	private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	[Address(RVA = "0x20392C0", Offset = "0x20386C0", Length = "0x17E")]
	[Token(Token = "0x6000932")]
	internal static bool TryStringToNumber(ReadOnlySpan<Char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	[Address(RVA = "0x2039440", Offset = "0x2038840", Length = "0x19B")]
	[Token(Token = "0x60008FF")]
	private static bool TryUInt32ToDecStr(uint value, int digits, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x20395E0", Offset = "0x20389E0", Length = "0x1E2")]
	[Token(Token = "0x6000907")]
	private static bool TryUInt64ToDecStr(ulong value, int digits, Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x20397D0", Offset = "0x2038BD0", Length = "0x3F")]
	[Token(Token = "0x60008FD")]
	internal static Char* UInt32ToDecChars(Char* bufferEnd, uint value, int digits) { }

	[Address(RVA = "0x2039810", Offset = "0x2038C10", Length = "0x173")]
	[Token(Token = "0x60008FE")]
	private static string UInt32ToDecStr(uint value, int digits) { }

	[Address(RVA = "0x2039990", Offset = "0x2038D90", Length = "0xFC")]
	[Token(Token = "0x60008FC")]
	private static void UInt32ToNumber(uint value, ref NumberBuffer number) { }

	[Address(RVA = "0x2039A90", Offset = "0x2038E90", Length = "0x1B8")]
	[Token(Token = "0x6000906")]
	private static string UInt64ToDecStr(ulong value, int digits) { }

	[Address(RVA = "0x2039C50", Offset = "0x2039050", Length = "0x1BC")]
	[Token(Token = "0x6000905")]
	private static void UInt64ToNumber(ulong value, ref NumberBuffer number) { }

}

