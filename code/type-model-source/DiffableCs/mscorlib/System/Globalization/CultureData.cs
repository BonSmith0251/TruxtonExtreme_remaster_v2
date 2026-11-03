namespace System.Globalization;

[Token(Token = "0x2000572")]
internal class CultureData
{
	[Token(Token = "0x2000573")]
	public struct NumberFormatEntryManaged
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40016D6")]
		internal int currency_decimal_digits; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40016D7")]
		internal int currency_decimal_separator; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40016D8")]
		internal int currency_group_separator; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40016D9")]
		internal int currency_group_sizes0; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40016DA")]
		internal int currency_group_sizes1; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40016DB")]
		internal int currency_negative_pattern; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40016DC")]
		internal int currency_positive_pattern; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40016DD")]
		internal int currency_symbol; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40016DE")]
		internal int nan_symbol; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40016DF")]
		internal int negative_infinity_symbol; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40016E0")]
		internal int negative_sign; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40016E1")]
		internal int number_decimal_digits; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40016E2")]
		internal int number_decimal_separator; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40016E3")]
		internal int number_group_separator; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40016E4")]
		internal int number_group_sizes0; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40016E5")]
		internal int number_group_sizes1; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40016E6")]
		internal int number_negative_pattern; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40016E7")]
		internal int per_mille_symbol; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40016E8")]
		internal int percent_negative_pattern; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40016E9")]
		internal int percent_positive_pattern; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40016EA")]
		internal int percent_symbol; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40016EB")]
		internal int positive_infinity_symbol; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40016EC")]
		internal int positive_sign; //Field offset: 0x58

	}

	[Token(Token = "0x40016D5")]
	private static CultureData s_Invariant; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016C1")]
	private string sAM1159; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016C2")]
	private string sPM2359; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016C3")]
	private string sTimeSeparator; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016C4")]
	private String[] saLongTimes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016C5")]
	private String[] saShortTimes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40016C6")]
	private int iFirstDayOfWeek; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40016C7")]
	private int iFirstWeekOfYear; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40016C8")]
	private Int32[] waCalendars; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40016C9")]
	private CalendarData[] calendars; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40016CA")]
	private string sISO639Language; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40016CB")]
	private readonly string sRealName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016CC")]
	private bool bUseOverrides; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40016CD")]
	private int calendarId; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40016CE")]
	private int numberIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40016CF")]
	private int iDefaultAnsiCodePage; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016D0")]
	private int iDefaultOemCodePage; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40016D1")]
	private int iDefaultMacCodePage; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016D2")]
	private int iDefaultEbcdicCodePage; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40016D3")]
	private bool isRightToLeft; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016D4")]
	private string sListSeparator; //Field offset: 0x80

	[Token(Token = "0x170005D5")]
	internal Int32[] CalendarIds
	{
		[Address(RVA = "0x1FA9D20", Offset = "0x1FA9120", Length = "0x1AC")]
		[Token(Token = "0x6002848")]
		internal get { } //Length: 428
	}

	[Token(Token = "0x170005D7")]
	internal string CultureName
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600284B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005D0")]
	internal int IFIRSTDAYOFWEEK
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6002843")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170005D1")]
	internal int IFIRSTWEEKOFYEAR
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6002844")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170005CC")]
	public static CultureData Invariant
	{
		[Address(RVA = "0x1FA9ED0", Offset = "0x1FA92D0", Length = "0x3FB")]
		[Token(Token = "0x600283B")]
		 get { } //Length: 1019
	}

	[Token(Token = "0x170005D6")]
	internal bool IsInvariantCulture
	{
		[Address(RVA = "0x1FAA2D0", Offset = "0x1FA96D0", Length = "0xB")]
		[Token(Token = "0x600284A")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x170005CD")]
	internal String[] LongTimes
	{
		[Address(RVA = "0xFAB870", Offset = "0xFAAC70", Length = "0x18")]
		[Token(Token = "0x6002840")]
		internal get { } //Length: 24
	}

	[Token(Token = "0x170005D2")]
	internal string SAM1159
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6002845")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005D8")]
	internal string SCOMPAREINFO
	{
		[Address(RVA = "0x1FAA2E0", Offset = "0x1FA96E0", Length = "0x2C")]
		[Token(Token = "0x600284C")]
		internal get { } //Length: 44
	}

	[Token(Token = "0x170005CE")]
	internal String[] ShortTimes
	{
		[Address(RVA = "0x1FAA310", Offset = "0x1FA9710", Length = "0x18")]
		[Token(Token = "0x6002841")]
		internal get { } //Length: 24
	}

	[Token(Token = "0x170005CF")]
	internal string SISO639LANGNAME
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6002842")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005D3")]
	internal string SPM2359
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6002846")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005D9")]
	internal string STEXTINFO
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600284D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005D4")]
	internal string TimeSeparator
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002847")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005DA")]
	internal bool UseUserOverride
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x600284E")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1FA9C10", Offset = "0x1FA9010", Length = "0x31")]
	[Token(Token = "0x600283A")]
	private CultureData(string name) { }

	[Address(RVA = "0x1FA89B0", Offset = "0x1FA7DB0", Length = "0x1F")]
	[Token(Token = "0x6002850")]
	internal String[] AbbrevEraNames(int calendarId) { }

	[Address(RVA = "0x1FA89D0", Offset = "0x1FA7DD0", Length = "0x1F")]
	[Token(Token = "0x6002856")]
	internal String[] AbbreviatedDayNames(int calendarId) { }

	[Address(RVA = "0x1FA89F0", Offset = "0x1FA7DF0", Length = "0x1F")]
	[Token(Token = "0x6002851")]
	internal String[] AbbreviatedEnglishEraNames(int calendarId) { }

	[Address(RVA = "0x1FA8A10", Offset = "0x1FA7E10", Length = "0x22")]
	[Token(Token = "0x600285A")]
	internal String[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	[Address(RVA = "0x1FA8A40", Offset = "0x1FA7E40", Length = "0x1F")]
	[Token(Token = "0x6002859")]
	internal String[] AbbreviatedMonthNames(int calendarId) { }

	[Address(RVA = "0x1FA9C50", Offset = "0x1FA9050", Length = "0xA7")]
	[Token(Token = "0x6002866")]
	private Int32[] create_group_sizes_array(int gs0, int gs1) { }

	[Address(RVA = "0x1FA8A60", Offset = "0x1FA7E60", Length = "0xCA")]
	[Token(Token = "0x600285D")]
	internal string DateSeparator(int calendarId) { }

	[Address(RVA = "0x1FA8B30", Offset = "0x1FA7F30", Length = "0x1F")]
	[Token(Token = "0x6002855")]
	internal String[] DayNames(int calendarId) { }

	[Address(RVA = "0x1FA8B50", Offset = "0x1FA7F50", Length = "0x1F")]
	[Token(Token = "0x600284F")]
	internal String[] EraNames(int calendarId) { }

	[Address(RVA = "0x1FA9D00", Offset = "0x1FA9100", Length = "0x5")]
	[Token(Token = "0x600283E")]
	private void fill_culture_data(int datetimeIndex) { }

	[Address(RVA = "0x1FA9D10", Offset = "0x1FA9110", Length = "0x5")]
	[Token(Token = "0x6002868")]
	private static Byte* fill_number_data(int index, ref NumberFormatEntryManaged nfe) { }

	[Address(RVA = "0x1FA8B70", Offset = "0x1FA7F70", Length = "0x1F")]
	[Token(Token = "0x6002858")]
	internal String[] GenitiveMonthNames(int calendarId) { }

	[Address(RVA = "0x1FA9D20", Offset = "0x1FA9120", Length = "0x1AC")]
	[Token(Token = "0x6002848")]
	internal Int32[] get_CalendarIds() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600284B")]
	internal string get_CultureName() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6002843")]
	internal int get_IFIRSTDAYOFWEEK() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6002844")]
	internal int get_IFIRSTWEEKOFYEAR() { }

	[Address(RVA = "0x1FA9ED0", Offset = "0x1FA92D0", Length = "0x3FB")]
	[Token(Token = "0x600283B")]
	public static CultureData get_Invariant() { }

	[Address(RVA = "0x1FAA2D0", Offset = "0x1FA96D0", Length = "0xB")]
	[Token(Token = "0x600284A")]
	internal bool get_IsInvariantCulture() { }

	[Address(RVA = "0xFAB870", Offset = "0xFAAC70", Length = "0x18")]
	[Token(Token = "0x6002840")]
	internal String[] get_LongTimes() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6002845")]
	internal string get_SAM1159() { }

	[Address(RVA = "0x1FAA2E0", Offset = "0x1FA96E0", Length = "0x2C")]
	[Token(Token = "0x600284C")]
	internal string get_SCOMPAREINFO() { }

	[Address(RVA = "0x1FAA310", Offset = "0x1FA9710", Length = "0x18")]
	[Token(Token = "0x6002841")]
	internal String[] get_ShortTimes() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6002842")]
	internal string get_SISO639LANGNAME() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6002846")]
	internal string get_SPM2359() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600284D")]
	internal string get_STEXTINFO() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6002847")]
	internal string get_TimeSeparator() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x600284E")]
	internal bool get_UseUserOverride() { }

	[Address(RVA = "0x1FA8E30", Offset = "0x1FA8230", Length = "0x13F")]
	[Token(Token = "0x600283F")]
	public CalendarData GetCalendar(int calendarId) { }

	[Address(RVA = "0x1FA8B90", Offset = "0x1FA7F90", Length = "0x296")]
	[Token(Token = "0x6002849")]
	internal CalendarId[] GetCalendarIds() { }

	[Address(RVA = "0x1FA8F70", Offset = "0x1FA8370", Length = "0x111")]
	[Token(Token = "0x600283D")]
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	[Address(RVA = "0x1FA9090", Offset = "0x1FA8490", Length = "0x7F")]
	[Token(Token = "0x600283C")]
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	[Address(RVA = "0x1FA9110", Offset = "0x1FA8510", Length = "0x3C")]
	[Token(Token = "0x600285E")]
	private static string GetDateSeparator(string format) { }

	[Address(RVA = "0x1FA9150", Offset = "0x1FA8550", Length = "0x57A")]
	[Token(Token = "0x6002867")]
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	[Address(RVA = "0x1FA96D0", Offset = "0x1FA8AD0", Length = "0x1DE")]
	[Token(Token = "0x600285F")]
	private static string GetSeparator(string format, string timeParts) { }

	[Address(RVA = "0x1FAA330", Offset = "0x1FA9730", Length = "0x5D")]
	[Token(Token = "0x6002865")]
	private static string idx2string(Byte* data, int idx) { }

	[Address(RVA = "0x1FA98B0", Offset = "0x1FA8CB0", Length = "0xEC")]
	[Token(Token = "0x6002860")]
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	[Address(RVA = "0x1FA99A0", Offset = "0x1FA8DA0", Length = "0x22")]
	[Token(Token = "0x600285B")]
	internal String[] LeapYearMonthNames(int calendarId) { }

	[Address(RVA = "0x1FA99D0", Offset = "0x1FA8DD0", Length = "0x1F")]
	[Token(Token = "0x6002853")]
	internal String[] LongDates(int calendarId) { }

	[Address(RVA = "0x1FA99F0", Offset = "0x1FA8DF0", Length = "0x1F")]
	[Token(Token = "0x600285C")]
	internal string MonthDay(int calendarId) { }

	[Address(RVA = "0x1FA9A10", Offset = "0x1FA8E10", Length = "0x1F")]
	[Token(Token = "0x6002857")]
	internal String[] MonthNames(int calendarId) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002863")]
	internal static string ReescapeWin32String(string str) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002862")]
	internal static String[] ReescapeWin32Strings(String[] array) { }

	[Address(RVA = "0x1FA9A30", Offset = "0x1FA8E30", Length = "0x1F")]
	[Token(Token = "0x6002852")]
	internal String[] ShortDates(int calendarId) { }

	[Address(RVA = "0x1FAA390", Offset = "0x1FA9790", Length = "0x1C")]
	[Token(Token = "0x6002864")]
	private static int strlen(Byte* s) { }

	[Address(RVA = "0x1FA9A50", Offset = "0x1FA8E50", Length = "0x197")]
	[Token(Token = "0x6002861")]
	private static string UnescapeNlsString(string str, int start, int end) { }

	[Address(RVA = "0x1FA9BF0", Offset = "0x1FA8FF0", Length = "0x1F")]
	[Token(Token = "0x6002854")]
	internal String[] YearMonths(int calendarId) { }

}

