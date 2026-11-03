namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200056B")]
public class TaiwanCalendar : Calendar
{
	[Token(Token = "0x40016A9")]
	internal static EraInfo[] taiwanEraInfo; //Field offset: 0x0
	[Token(Token = "0x40016AA")]
	internal static Calendar s_defaultInstance; //Field offset: 0x8
	[Token(Token = "0x40016AC")]
	internal static readonly DateTime calendarMinValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016AB")]
	internal GregorianCalendarHelper helper; //Field offset: 0x20

	[Token(Token = "0x170005BA")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x1F7A3A0", Offset = "0x1F797A0", Length = "0x1D")]
		[Token(Token = "0x60027D2")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170005B9")]
	internal virtual int ID
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x60027C7")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x170005B8")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x1F7C4C0", Offset = "0x1F7B8C0", Length = "0x4F")]
		[Token(Token = "0x60027C5")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x170005B7")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x1F7C510", Offset = "0x1F7B910", Length = "0x4F")]
		[Token(Token = "0x60027C4")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170005BB")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x1F7A460", Offset = "0x1F79860", Length = "0x6C")]
		[Token(Token = "0x60027D3")]
		 get { } //Length: 108
		[Address(RVA = "0x1F7C560", Offset = "0x1F7B960", Length = "0x133")]
		[Token(Token = "0x60027D4")]
		 set { } //Length: 307
	}

	[Address(RVA = "0x1F7C1D0", Offset = "0x1F7B5D0", Length = "0x16E")]
	[Token(Token = "0x60027D6")]
	private static TaiwanCalendar() { }

	[Address(RVA = "0x1F7C340", Offset = "0x1F7B740", Length = "0x172")]
	[Token(Token = "0x60027C6")]
	public TaiwanCalendar() { }

	[Address(RVA = "0x1F7A3A0", Offset = "0x1F797A0", Length = "0x1D")]
	[Token(Token = "0x60027D2")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x60027C7")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x1F7C4C0", Offset = "0x1F7B8C0", Length = "0x4F")]
	[Token(Token = "0x60027C5")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x1F7C510", Offset = "0x1F7B910", Length = "0x4F")]
	[Token(Token = "0x60027C4")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x1F7A460", Offset = "0x1F79860", Length = "0x6C")]
	[Token(Token = "0x60027D3")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x1F797C0", Offset = "0x1F78BC0", Length = "0x1E")]
	[Token(Token = "0x60027CA")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x1F797E0", Offset = "0x1F78BE0", Length = "0x1E")]
	[Token(Token = "0x60027CB")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x1F79800", Offset = "0x1F78C00", Length = "0x24")]
	[Token(Token = "0x60027C8")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F79830", Offset = "0x1F78C30", Length = "0x1E")]
	[Token(Token = "0x60027C9")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x1F7BF50", Offset = "0x1F7B350", Length = "0xED")]
	[Token(Token = "0x60027C3")]
	internal static Calendar GetDefaultInstance() { }

	[Address(RVA = "0x1F79F20", Offset = "0x1F79320", Length = "0x1E")]
	[Token(Token = "0x60027CD")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x1F79F40", Offset = "0x1F79340", Length = "0x1E")]
	[Token(Token = "0x60027CE")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x1F79F60", Offset = "0x1F79360", Length = "0x2D")]
	[Token(Token = "0x60027CC")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F79F90", Offset = "0x1F79390", Length = "0x1E")]
	[Token(Token = "0x60027CF")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x1F79FB0", Offset = "0x1F793B0", Length = "0x1E")]
	[Token(Token = "0x60027D0")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F7C560", Offset = "0x1F7B960", Length = "0x133")]
	[Token(Token = "0x60027D4")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x1F7A000", Offset = "0x1F79400", Length = "0x27")]
	[Token(Token = "0x60027D1")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F7C040", Offset = "0x1F7B440", Length = "0x18D")]
	[Token(Token = "0x60027D5")]
	public virtual int ToFourDigitYear(int year) { }

}

