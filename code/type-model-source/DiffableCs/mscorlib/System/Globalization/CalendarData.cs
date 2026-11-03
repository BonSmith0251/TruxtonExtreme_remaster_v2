namespace System.Globalization;

[Token(Token = "0x2000562")]
internal class CalendarData
{
	[Token(Token = "0x4001648")]
	internal const int MAX_CALENDARS = 23; //Field offset: 0x0
	[Token(Token = "0x400165C")]
	internal static CalendarData Invariant; //Field offset: 0x0
	[Token(Token = "0x400165D")]
	private static String[] HEBREW_MONTH_NAMES; //Field offset: 0x8
	[Token(Token = "0x400165E")]
	private static String[] HEBREW_LEAP_MONTH_NAMES; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001649")]
	internal string sNativeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400164A")]
	internal String[] saShortDates; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400164B")]
	internal String[] saYearMonths; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400164C")]
	internal String[] saLongDates; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400164D")]
	internal string sMonthDay; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400164E")]
	internal String[] saEraNames; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400164F")]
	internal String[] saAbbrevEraNames; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001650")]
	internal String[] saAbbrevEnglishEraNames; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001651")]
	internal String[] saDayNames; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001652")]
	internal String[] saAbbrevDayNames; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001653")]
	internal String[] saSuperShortDayNames; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001654")]
	internal String[] saMonthNames; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001655")]
	internal String[] saAbbrevMonthNames; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001656")]
	internal String[] saMonthGenitiveNames; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001657")]
	internal String[] saAbbrevMonthGenitiveNames; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001658")]
	internal String[] saLeapYearMonthNames; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001659")]
	internal int iTwoDigitYearMax; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400165A")]
	internal int iCurrentEra; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400165B")]
	internal bool bUseUserOverrides; //Field offset: 0x98

	[Address(RVA = "0x1F6FD90", Offset = "0x1F6F190", Length = "0x104B")]
	[Token(Token = "0x600271C")]
	private static CalendarData() { }

	[Address(RVA = "0x1F71570", Offset = "0x1F70970", Length = "0x11")]
	[Token(Token = "0x600271B")]
	private CalendarData() { }

	[Address(RVA = "0x1F70DE0", Offset = "0x1F701E0", Length = "0x78D")]
	[Token(Token = "0x600271D")]
	internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides) { }

	[Address(RVA = "0x1F6EE90", Offset = "0x1F6E290", Length = "0xAC")]
	[Token(Token = "0x6002723")]
	private static string CalendarIdToCultureName(int calendarId) { }

	[Address(RVA = "0x1F71590", Offset = "0x1F70990", Length = "0x5")]
	[Token(Token = "0x6002726")]
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

	[Address(RVA = "0x1F6F020", Offset = "0x1F6E420", Length = "0x194")]
	[Token(Token = "0x6002722")]
	internal static CalendarData GetCalendarData(int calendarId) { }

	[Address(RVA = "0x1F6F210", Offset = "0x1F6E610", Length = "0x1CF")]
	[Token(Token = "0x6002720")]
	private static String[] GetJapaneseEnglishEraNames() { }

	[Address(RVA = "0x1F6F3E0", Offset = "0x1F6E7E0", Length = "0x1CF")]
	[Token(Token = "0x600271F")]
	private static String[] GetJapaneseEraNames() { }

	[Address(RVA = "0x1F6F5B0", Offset = "0x1F6E9B0", Length = "0x13C")]
	[Token(Token = "0x6002721")]
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	[Address(RVA = "0x1F6F930", Offset = "0x1F6ED30", Length = "0xF4")]
	[Token(Token = "0x600271E")]
	private void InitializeEraNames(string localeName, int calendarId) { }

	[Address(RVA = "0x1F715A0", Offset = "0x1F709A0", Length = "0xEB")]
	[Token(Token = "0x6002725")]
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
	[Token(Token = "0x6002724")]
	public static int nativeGetTwoDigitYearMax(int calID) { }

}

