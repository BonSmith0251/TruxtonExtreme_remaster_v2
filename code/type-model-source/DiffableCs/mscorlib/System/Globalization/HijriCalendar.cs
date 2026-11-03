namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000567")]
public class HijriCalendar : Calendar
{
	[Token(Token = "0x400167A")]
	public static readonly int HijriEra; //Field offset: 0x0
	[Token(Token = "0x400167B")]
	internal static readonly Int32[] HijriMonthDays; //Field offset: 0x8
	[Token(Token = "0x400167D")]
	internal static readonly DateTime calendarMinValue; //Field offset: 0x10
	[Token(Token = "0x400167E")]
	internal static readonly DateTime calendarMaxValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400167C")]
	private int m_HijriAdvance; //Field offset: 0x20

	[Token(Token = "0x17000591")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x1F792D0", Offset = "0x1F786D0", Length = "0x89")]
		[Token(Token = "0x600276B")]
		 get { } //Length: 137
	}

	[Token(Token = "0x17000590")]
	public int HijriAdjustment
	{
		[Address(RVA = "0x1F79360", Offset = "0x1F78760", Length = "0x53")]
		[Token(Token = "0x600275F")]
		 get { } //Length: 83
	}

	[Token(Token = "0x1700058F")]
	internal virtual int ID
	{
		[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
		[Token(Token = "0x600275C")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x1700058E")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x1F793C0", Offset = "0x1F787C0", Length = "0x4F")]
		[Token(Token = "0x600275A")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x1700058D")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x1F79410", Offset = "0x1F78810", Length = "0x4F")]
		[Token(Token = "0x6002759")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000592")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x1F79460", Offset = "0x1F78860", Length = "0x6C")]
		[Token(Token = "0x6002771")]
		 get { } //Length: 108
		[Address(RVA = "0x1F794D0", Offset = "0x1F788D0", Length = "0x10C")]
		[Token(Token = "0x6002772")]
		 set { } //Length: 268
	}

	[Address(RVA = "0x1F79180", Offset = "0x1F78580", Length = "0x12C")]
	[Token(Token = "0x6002774")]
	private static HijriCalendar() { }

	[Address(RVA = "0x1F792B0", Offset = "0x1F786B0", Length = "0x1C")]
	[Token(Token = "0x600275B")]
	public HijriCalendar() { }

	[Address(RVA = "0x1F77C30", Offset = "0x1F77030", Length = "0xC6")]
	[Token(Token = "0x6002762")]
	internal static void CheckEraRange(int era) { }

	[Address(RVA = "0x1F77D00", Offset = "0x1F77100", Length = "0x1FD")]
	[Token(Token = "0x6002761")]
	internal static void CheckTicksRange(long ticks) { }

	[Address(RVA = "0x1F77F00", Offset = "0x1F77300", Length = "0x1B5")]
	[Token(Token = "0x6002764")]
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	[Address(RVA = "0x1F780C0", Offset = "0x1F774C0", Length = "0x1DE")]
	[Token(Token = "0x6002763")]
	internal static void CheckYearRange(int year, int era) { }

	[Address(RVA = "0x1F782A0", Offset = "0x1F776A0", Length = "0xB6")]
	[Token(Token = "0x600275E")]
	private long DaysUpToHijriYear(int HijriYear) { }

	[Address(RVA = "0x1F792D0", Offset = "0x1F786D0", Length = "0x89")]
	[Token(Token = "0x600276B")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x1F79360", Offset = "0x1F78760", Length = "0x53")]
	[Token(Token = "0x600275F")]
	public int get_HijriAdjustment() { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x600275C")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x1F793C0", Offset = "0x1F787C0", Length = "0x4F")]
	[Token(Token = "0x600275A")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x1F79410", Offset = "0x1F78810", Length = "0x4F")]
	[Token(Token = "0x6002759")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x1F79460", Offset = "0x1F78860", Length = "0x6C")]
	[Token(Token = "0x6002771")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x1F78360", Offset = "0x1F77760", Length = "0x10A")]
	[Token(Token = "0x600275D")]
	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6002760")]
	private static int GetAdvanceHijriDate() { }

	[Address(RVA = "0x1F78470", Offset = "0x1F77870", Length = "0x29E")]
	[Token(Token = "0x6002765")]
	internal override int GetDatePart(long ticks, int part) { }

	[Address(RVA = "0x1F78710", Offset = "0x1F77B10", Length = "0x70")]
	[Token(Token = "0x6002766")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x1F78780", Offset = "0x1F77B80", Length = "0x7C")]
	[Token(Token = "0x6002767")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x1F78800", Offset = "0x1F77C00", Length = "0x244")]
	[Token(Token = "0x6002768")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F78A50", Offset = "0x1F77E50", Length = "0x8C")]
	[Token(Token = "0x6002769")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x1F78AE0", Offset = "0x1F77EE0", Length = "0x8B")]
	[Token(Token = "0x600276A")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x1F78B70", Offset = "0x1F77F70", Length = "0x70")]
	[Token(Token = "0x600276C")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x1F78BE0", Offset = "0x1F77FE0", Length = "0x5C")]
	[Token(Token = "0x600276D")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F78C40", Offset = "0x1F78040", Length = "0x6D")]
	[Token(Token = "0x600276E")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x1F78CB0", Offset = "0x1F780B0", Length = "0x7B")]
	[Token(Token = "0x600276F")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F794D0", Offset = "0x1F788D0", Length = "0x10C")]
	[Token(Token = "0x6002772")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x1F78D30", Offset = "0x1F78130", Length = "0x2B4")]
	[Token(Token = "0x6002770")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F78FF0", Offset = "0x1F783F0", Length = "0x181")]
	[Token(Token = "0x6002773")]
	public virtual int ToFourDigitYear(int year) { }

}

