namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000568")]
public class JapaneseCalendar : Calendar
{
	[Token(Token = "0x400167F")]
	internal static readonly DateTime calendarMinValue; //Field offset: 0x0
	[Token(Token = "0x4001680")]
	internal static EraInfo[] japaneseEraInfo; //Field offset: 0x8
	[Token(Token = "0x4001681")]
	internal static Calendar s_defaultInstance; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001682")]
	internal GregorianCalendarHelper helper; //Field offset: 0x20

	[Token(Token = "0x17000596")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x1F7A3A0", Offset = "0x1F797A0", Length = "0x1D")]
		[Token(Token = "0x6002787")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000595")]
	internal virtual int ID
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x600277B")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x17000594")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x1F7A3C0", Offset = "0x1F797C0", Length = "0x4F")]
		[Token(Token = "0x6002776")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x17000593")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x1F7A410", Offset = "0x1F79810", Length = "0x4E")]
		[Token(Token = "0x6002775")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000597")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x1F7A460", Offset = "0x1F79860", Length = "0x6C")]
		[Token(Token = "0x600278B")]
		 get { } //Length: 108
		[Address(RVA = "0x1F7A4D0", Offset = "0x1F798D0", Length = "0x133")]
		[Token(Token = "0x600278C")]
		 set { } //Length: 307
	}

	[Address(RVA = "0x1F7A1C0", Offset = "0x1F795C0", Length = "0x62")]
	[Token(Token = "0x600278D")]
	private static JapaneseCalendar() { }

	[Address(RVA = "0x1F7A230", Offset = "0x1F79630", Length = "0x168")]
	[Token(Token = "0x600277A")]
	public JapaneseCalendar() { }

	[Address(RVA = "0x1F795E0", Offset = "0x1F789E0", Length = "0xEA")]
	[Token(Token = "0x6002789")]
	internal static String[] EnglishEraNames() { }

	[Address(RVA = "0x1F796D0", Offset = "0x1F78AD0", Length = "0xEA")]
	[Token(Token = "0x6002788")]
	internal static String[] EraNames() { }

	[Address(RVA = "0x1F7A3A0", Offset = "0x1F797A0", Length = "0x1D")]
	[Token(Token = "0x6002787")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x600277B")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x1F7A3C0", Offset = "0x1F797C0", Length = "0x4F")]
	[Token(Token = "0x6002776")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x1F7A410", Offset = "0x1F79810", Length = "0x4E")]
	[Token(Token = "0x6002775")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x1F7A460", Offset = "0x1F79860", Length = "0x6C")]
	[Token(Token = "0x600278B")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x1F797C0", Offset = "0x1F78BC0", Length = "0x1E")]
	[Token(Token = "0x600277E")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x1F797E0", Offset = "0x1F78BE0", Length = "0x1E")]
	[Token(Token = "0x600277F")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x1F79800", Offset = "0x1F78C00", Length = "0x24")]
	[Token(Token = "0x600277C")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F79830", Offset = "0x1F78C30", Length = "0x1E")]
	[Token(Token = "0x600277D")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x1F79850", Offset = "0x1F78C50", Length = "0xED")]
	[Token(Token = "0x6002779")]
	internal static Calendar GetDefaultInstance() { }

	[Address(RVA = "0x1F79F20", Offset = "0x1F79320", Length = "0x1E")]
	[Token(Token = "0x6002781")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x1F79940", Offset = "0x1F78D40", Length = "0x5DA")]
	[Token(Token = "0x6002777")]
	internal static EraInfo[] GetEraInfo() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6002778")]
	private static EraInfo[] GetErasFromRegistry() { }

	[Address(RVA = "0x1F79F40", Offset = "0x1F79340", Length = "0x1E")]
	[Token(Token = "0x6002782")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x1F79F60", Offset = "0x1F79360", Length = "0x2D")]
	[Token(Token = "0x6002780")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F79F90", Offset = "0x1F79390", Length = "0x1E")]
	[Token(Token = "0x6002783")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x1F79FB0", Offset = "0x1F793B0", Length = "0x1E")]
	[Token(Token = "0x6002784")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F79FD0", Offset = "0x1F793D0", Length = "0x2D")]
	[Token(Token = "0x600278A")]
	internal virtual bool IsValidYear(int year, int era) { }

	[Address(RVA = "0x1F7A4D0", Offset = "0x1F798D0", Length = "0x133")]
	[Token(Token = "0x600278C")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x1F7A000", Offset = "0x1F79400", Length = "0x27")]
	[Token(Token = "0x6002785")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F7A030", Offset = "0x1F79430", Length = "0x18D")]
	[Token(Token = "0x6002786")]
	public virtual int ToFourDigitYear(int year) { }

}

