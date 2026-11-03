namespace System;

[Token(Token = "0x20000DA")]
internal static class DateTimeParse
{
	[CompilerGenerated]
	[Token(Token = "0x20000DF")]
	private sealed class <>c
	{
		[Token(Token = "0x4000344")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000345")]
		public static Func<MatchNumberDelegate> <>9__98_0; //Field offset: 0x8

		[Address(RVA = "0x203A9B0", Offset = "0x2039DB0", Length = "0x67")]
		[Token(Token = "0x6000727")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000728")]
		public <>c() { }

		[Address(RVA = "0x203A8C0", Offset = "0x2039CC0", Length = "0xE7")]
		[Token(Token = "0x6000729")]
		internal MatchNumberDelegate <DoStrictParse>b__98_0() { }

	}

	[Token(Token = "0x20000DE")]
	public enum DS : int
	{
		BEGIN = 0,
		N = 1,
		NN = 2,
		D_Nd = 3,
		D_NN = 4,
		D_NNd = 5,
		D_M = 6,
		D_MN = 7,
		D_NM = 8,
		D_MNd = 9,
		D_NDS = 10,
		D_Y = 11,
		D_YN = 12,
		D_YNd = 13,
		D_YM = 14,
		D_YMd = 15,
		D_S = 16,
		T_S = 17,
		T_Nt = 18,
		T_NNt = 19,
		ERROR = 20,
		DX_NN = 21,
		DX_NNN = 22,
		DX_MN = 23,
		DX_NM = 24,
		DX_MNN = 25,
		DX_DS = 26,
		DX_DSN = 27,
		DX_NDS = 28,
		DX_NNDS = 29,
		DX_YNN = 30,
		DX_YMN = 31,
		DX_YN = 32,
		DX_YM = 33,
		TX_N = 34,
		TX_NN = 35,
		TX_NNN = 36,
		TX_TS = 37,
		DX_NNY = 38,
	}

	[Token(Token = "0x20000DC")]
	public enum DTT : int
	{
		End = 0,
		NumEnd = 1,
		NumAmpm = 2,
		NumSpace = 3,
		NumDatesep = 4,
		NumTimesep = 5,
		MonthEnd = 6,
		MonthSpace = 7,
		MonthDatesep = 8,
		NumDatesuff = 9,
		NumTimesuff = 10,
		DayOfWeek = 11,
		YearSpace = 12,
		YearDateSep = 13,
		YearEnd = 14,
		TimeZone = 15,
		Era = 16,
		NumUTCTimeMark = 17,
		Unk = 18,
		NumLocalTimeMark = 19,
		Max = 20,
	}

	[Token(Token = "0x20000DB")]
	public sealed class MatchNumberDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2029CE0", Offset = "0x20290E0", Length = "0xB5")]
		[Token(Token = "0x6000725")]
		public MatchNumberDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000726")]
		public override bool Invoke(ref __DTString str, int digitLen, out int result) { }

	}

	[Token(Token = "0x20000DD")]
	public enum TM : int
	{
		NotSet = -1,
		AM = 0,
		PM = 1,
	}

	[Token(Token = "0x4000300")]
	internal static MatchNumberDelegate m_hebrewNumberParser; //Field offset: 0x0
	[Token(Token = "0x4000301")]
	private static DS[][] dateParsingStates; //Field offset: 0x8

	[Address(RVA = "0x201A090", Offset = "0x2019490", Length = "0x6BC")]
	[Token(Token = "0x6000724")]
	private static DateTimeParse() { }

	[Address(RVA = "0x200E580", Offset = "0x200D980", Length = "0x36")]
	[Token(Token = "0x60006FA")]
	private static bool AdjustHour(ref int hour, TM timeMark) { }

	[Address(RVA = "0x200E5C0", Offset = "0x200D9C0", Length = "0xB0")]
	[Token(Token = "0x60006F9")]
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x200E680", Offset = "0x200DA80", Length = "0x2EC")]
	[Token(Token = "0x600070C")]
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	[Address(RVA = "0x200E970", Offset = "0x200DD70", Length = "0x121")]
	[Token(Token = "0x600070B")]
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	[Address(RVA = "0x200EAA0", Offset = "0x200DEA0", Length = "0x231")]
	[Token(Token = "0x600071D")]
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	[Address(RVA = "0x200ECE0", Offset = "0x200E0E0", Length = "0x98")]
	[Token(Token = "0x600071B")]
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	[Address(RVA = "0x200ED80", Offset = "0x200E180", Length = "0x28C")]
	[Token(Token = "0x600070A")]
	private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles) { }

	[Address(RVA = "0x200F010", Offset = "0x200E410", Length = "0x25F")]
	[Token(Token = "0x6000709")]
	private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	[Address(RVA = "0x200F270", Offset = "0x200E670", Length = "0x90C")]
	[Token(Token = "0x6000722")]
	private static bool DoStrictParse(ReadOnlySpan<Char> s, ReadOnlySpan<Char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	[Address(RVA = "0x200FB80", Offset = "0x200EF80", Length = "0x63C")]
	[Token(Token = "0x600071E")]
	private static string ExpandPredefinedFormat(ReadOnlySpan<Char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	[Address(RVA = "0x2010230", Offset = "0x200F630", Length = "0x3F")]
	[Token(Token = "0x60006FE")]
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x2010270", Offset = "0x200F670", Length = "0x9A")]
	[Token(Token = "0x60006FF")]
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x2010310", Offset = "0x200F710", Length = "0x24C")]
	[Token(Token = "0x6000700")]
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2010560", Offset = "0x200F960", Length = "0x145")]
	[Token(Token = "0x600071C")]
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	[Address(RVA = "0x20106B0", Offset = "0x200FAB0", Length = "0x50")]
	[Token(Token = "0x6000723")]
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	[Address(RVA = "0x2010B90", Offset = "0x200FF90", Length = "0x239")]
	[Token(Token = "0x60006F0")]
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x20108A0", Offset = "0x200FCA0", Length = "0x2E4")]
	[Token(Token = "0x60006F3")]
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2010DD0", Offset = "0x20101D0", Length = "0x239")]
	[Token(Token = "0x60006F2")]
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x20114C0", Offset = "0x20108C0", Length = "0x175")]
	[Token(Token = "0x60006EE")]
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2011010", Offset = "0x2010410", Length = "0x33A")]
	[Token(Token = "0x60006EF")]
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2011350", Offset = "0x2010750", Length = "0x16C")]
	[Token(Token = "0x60006F5")]
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2011700", Offset = "0x2010B00", Length = "0xA2")]
	[Token(Token = "0x60006F8")]
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x2011640", Offset = "0x2010A40", Length = "0xB8")]
	[Token(Token = "0x60006F6")]
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x2011900", Offset = "0x2010D00", Length = "0xAE")]
	[Token(Token = "0x60006F7")]
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x20117B0", Offset = "0x2010BB0", Length = "0x142")]
	[Token(Token = "0x60006F4")]
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x20119B0", Offset = "0x2010DB0", Length = "0x95")]
	[Token(Token = "0x60006ED")]
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	[Address(RVA = "0x2011A50", Offset = "0x2010E50", Length = "0x152")]
	[Token(Token = "0x60006F1")]
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2011BB0", Offset = "0x2010FB0", Length = "0xE7")]
	[Token(Token = "0x60006E2")]
	private static Calendar GetJapaneseCalendarDefaultInstance() { }

	[Address(RVA = "0x2011CA0", Offset = "0x20110A0", Length = "0x181")]
	[Token(Token = "0x60006E7")]
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	[Address(RVA = "0x2011E30", Offset = "0x2011230", Length = "0xE7")]
	[Token(Token = "0x60006E3")]
	internal static Calendar GetTaiwanCalendarDefaultInstance() { }

	[Address(RVA = "0x2012000", Offset = "0x2011400", Length = "0x43")]
	[Token(Token = "0x60006FB")]
	private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x2011FA0", Offset = "0x20113A0", Length = "0x5E")]
	[Token(Token = "0x60006FC")]
	private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x2011F20", Offset = "0x2011320", Length = "0x71")]
	[Token(Token = "0x60006FD")]
	private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x2012050", Offset = "0x2011450", Length = "0xA1")]
	[Token(Token = "0x60006DC")]
	private static bool GetTimeZoneName(ref __DTString str) { }

	[Address(RVA = "0x2012100", Offset = "0x2011500", Length = "0x225")]
	[Token(Token = "0x60006E5")]
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	[Address(RVA = "0x2012330", Offset = "0x2011730", Length = "0x141")]
	[Token(Token = "0x60006E6")]
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	[Address(RVA = "0x2012480", Offset = "0x2011880", Length = "0x170")]
	[Token(Token = "0x60006E0")]
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	[Address(RVA = "0x2012600", Offset = "0x2011A00", Length = "0xD")]
	[Token(Token = "0x60006DD")]
	internal static bool IsDigit(char ch) { }

	[Address(RVA = "0x2012610", Offset = "0x2011A10", Length = "0x1054")]
	[Token(Token = "0x60006E1")]
	private static bool Lex(DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	[Address(RVA = "0x20136A0", Offset = "0x2012AA0", Length = "0x152")]
	[Token(Token = "0x6000716")]
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x2013800", Offset = "0x2012C00", Length = "0x1C8")]
	[Token(Token = "0x6000714")]
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x20139D0", Offset = "0x2012DD0", Length = "0x143")]
	[Token(Token = "0x600071A")]
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) { }

	[Address(RVA = "0x2013B20", Offset = "0x2012F20", Length = "0x152")]
	[Token(Token = "0x6000717")]
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x2013C80", Offset = "0x2013080", Length = "0x188")]
	[Token(Token = "0x6000718")]
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x2013E10", Offset = "0x2013210", Length = "0x100")]
	[Token(Token = "0x600070E")]
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	[Address(RVA = "0x2013F10", Offset = "0x2013310", Length = "0x214")]
	[Token(Token = "0x6000715")]
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x2014130", Offset = "0x2013530", Length = "0x174")]
	[Token(Token = "0x6000719")]
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) { }

	[Address(RVA = "0x20142B0", Offset = "0x20136B0", Length = "0x1C1")]
	[Token(Token = "0x60006DB")]
	private static bool MatchWord(ref __DTString str, string target) { }

	[Address(RVA = "0x2017730", Offset = "0x2016B30", Length = "0x137")]
	[Token(Token = "0x6000705")]
	internal static DateTime Parse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	[Address(RVA = "0x2017870", Offset = "0x2016C70", Length = "0x11B")]
	[Token(Token = "0x6000704")]
	internal static DateTime Parse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	[Address(RVA = "0x2014480", Offset = "0x2013880", Length = "0x19B9")]
	[Token(Token = "0x6000720")]
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	[Address(RVA = "0x2015E40", Offset = "0x2015240", Length = "0xE4")]
	[Token(Token = "0x6000710")]
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	[Address(RVA = "0x2015F30", Offset = "0x2015330", Length = "0x91")]
	[Token(Token = "0x600070F")]
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	[Address(RVA = "0x2016100", Offset = "0x2015500", Length = "0x244")]
	[Token(Token = "0x60006D5")]
	internal static DateTime ParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	[Address(RVA = "0x2016350", Offset = "0x2015750", Length = "0x1E9")]
	[Token(Token = "0x60006D4")]
	internal static DateTime ParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	[Address(RVA = "0x2015FD0", Offset = "0x20153D0", Length = "0x12F")]
	[Token(Token = "0x60006D9")]
	internal static DateTime ParseExactMultiple(ReadOnlySpan<Char> s, String[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	[Address(RVA = "0x20166B0", Offset = "0x2015AB0", Length = "0xEA")]
	[Token(Token = "0x60006DE")]
	private static bool ParseFraction(ref __DTString str, out double result) { }

	[Address(RVA = "0x2016540", Offset = "0x2015940", Length = "0x16B")]
	[Token(Token = "0x6000711")]
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	[Address(RVA = "0x20167A0", Offset = "0x2015BA0", Length = "0x6A9")]
	[Token(Token = "0x600070D")]
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	[Address(RVA = "0x2016E50", Offset = "0x2016250", Length = "0xE6")]
	[Token(Token = "0x600071F")]
	private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2016F40", Offset = "0x2016340", Length = "0xA7")]
	[Token(Token = "0x6000712")]
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	[Address(RVA = "0x2017380", Offset = "0x2016780", Length = "0x3A3")]
	[Token(Token = "0x60006DF")]
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	[Address(RVA = "0x2016FF0", Offset = "0x20163F0", Length = "0x388")]
	[Token(Token = "0x6000713")]
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	[Address(RVA = "0x2017990", Offset = "0x2016D90", Length = "0xB9")]
	[Token(Token = "0x6000701")]
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	[Address(RVA = "0x2017A50", Offset = "0x2016E50", Length = "0x74")]
	[Token(Token = "0x6000702")]
	internal static bool ProcessHebrewTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2017FA0", Offset = "0x20173A0", Length = "0x628")]
	[Token(Token = "0x6000703")]
	internal static bool ProcessTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x2018610", Offset = "0x2017A10", Length = "0x7D")]
	[Token(Token = "0x60006EB")]
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	[Address(RVA = "0x2018690", Offset = "0x2017A90", Length = "0x7D")]
	[Token(Token = "0x60006EA")]
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	[Address(RVA = "0x2018710", Offset = "0x2017B10", Length = "0x7D")]
	[Token(Token = "0x60006EC")]
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	[Address(RVA = "0x2018790", Offset = "0x2017B90", Length = "0x83")]
	[Token(Token = "0x60006E9")]
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	[Address(RVA = "0x2018820", Offset = "0x2017C20", Length = "0x55")]
	[Token(Token = "0x60006E8")]
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	[Address(RVA = "0x20195A0", Offset = "0x20189A0", Length = "0x8EC")]
	[Token(Token = "0x6000708")]
	internal static bool TryParse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	[Address(RVA = "0x20192A0", Offset = "0x20186A0", Length = "0x18C")]
	[Token(Token = "0x6000707")]
	internal static bool TryParse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	[Address(RVA = "0x2019430", Offset = "0x2018830", Length = "0x164")]
	[Token(Token = "0x6000706")]
	internal static bool TryParse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	[Address(RVA = "0x2018C40", Offset = "0x2018040", Length = "0xF6")]
	[Token(Token = "0x60006D8")]
	internal static bool TryParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	[Address(RVA = "0x2018F40", Offset = "0x2018340", Length = "0x24D")]
	[Token(Token = "0x60006D7")]
	internal static bool TryParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	[Address(RVA = "0x2018D40", Offset = "0x2018140", Length = "0x1F8")]
	[Token(Token = "0x60006D6")]
	internal static bool TryParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	[Address(RVA = "0x2018880", Offset = "0x2017C80", Length = "0x3B1")]
	[Token(Token = "0x60006DA")]
	internal static bool TryParseExactMultiple(ReadOnlySpan<Char> s, String[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	[Address(RVA = "0x2019190", Offset = "0x2018590", Length = "0x10A")]
	[Token(Token = "0x6000721")]
	internal static bool TryParseQuoteString(ReadOnlySpan<Char> format, int pos, StringBuilder result, out int returnValue) { }

	[Address(RVA = "0x2019E90", Offset = "0x2019290", Length = "0x1F5")]
	[Token(Token = "0x60006E4")]
	private static bool VerifyValidPunctuation(ref __DTString str) { }

}

