namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000563")]
public class GregorianCalendar : Calendar
{
	[Token(Token = "0x4001660")]
	internal static readonly Int32[] DaysToMonth365; //Field offset: 0x0
	[Token(Token = "0x4001661")]
	internal static readonly Int32[] DaysToMonth366; //Field offset: 0x8
	[Token(Token = "0x4001662")]
	private static Calendar s_defaultInstance; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400165F")]
	internal GregorianCalendarTypes m_type; //Field offset: 0x20

	[Token(Token = "0x17000589")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x1F770A0", Offset = "0x1F764A0", Length = "0x53")]
		[Token(Token = "0x6002735")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000588")]
	internal virtual int ID
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600272D")]
		internal get { } //Length: 4
	}

	[ComVisible(False)]
	[Token(Token = "0x17000587")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x1F77100", Offset = "0x1F76500", Length = "0x4F")]
		[Token(Token = "0x6002729")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x17000586")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x1F77150", Offset = "0x1F76550", Length = "0x4F")]
		[Token(Token = "0x6002728")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700058A")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x1F771A0", Offset = "0x1F765A0", Length = "0x6C")]
		[Token(Token = "0x600273C")]
		 get { } //Length: 108
		[Address(RVA = "0x1F77210", Offset = "0x1F76610", Length = "0x10C")]
		[Token(Token = "0x600273D")]
		 set { } //Length: 268
	}

	[Address(RVA = "0x1F76E30", Offset = "0x1F76230", Length = "0xEA")]
	[Token(Token = "0x600273F")]
	private static GregorianCalendar() { }

	[Address(RVA = "0x1F76F20", Offset = "0x1F76320", Length = "0x2B")]
	[Token(Token = "0x600272B")]
	public GregorianCalendar() { }

	[Address(RVA = "0x1F76F50", Offset = "0x1F76350", Length = "0x149")]
	[Token(Token = "0x600272C")]
	public GregorianCalendar(GregorianCalendarTypes type) { }

	[Address(RVA = "0x1F770A0", Offset = "0x1F764A0", Length = "0x53")]
	[Token(Token = "0x6002735")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600272D")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x1F77100", Offset = "0x1F76500", Length = "0x4F")]
	[Token(Token = "0x6002729")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x1F77150", Offset = "0x1F76550", Length = "0x4F")]
	[Token(Token = "0x6002728")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x1F771A0", Offset = "0x1F765A0", Length = "0x6C")]
	[Token(Token = "0x600273C")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x1F75B30", Offset = "0x1F74F30", Length = "0x1EF")]
	[Token(Token = "0x600272F")]
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	[Address(RVA = "0x1F75D20", Offset = "0x1F75120", Length = "0x1CB")]
	[Token(Token = "0x600272E")]
	internal override int GetDatePart(long ticks, int part) { }

	[Address(RVA = "0x1F75EF0", Offset = "0x1F752F0", Length = "0x70")]
	[Token(Token = "0x6002730")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x1F75F60", Offset = "0x1F75360", Length = "0x7C")]
	[Token(Token = "0x6002731")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x1F75FE0", Offset = "0x1F753E0", Length = "0x302")]
	[Token(Token = "0x6002732")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F762F0", Offset = "0x1F756F0", Length = "0x1CC")]
	[Token(Token = "0x6002733")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x1F764C0", Offset = "0x1F758C0", Length = "0x102")]
	[Token(Token = "0x600272A")]
	internal static Calendar GetDefaultInstance() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6002734")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x1F765D0", Offset = "0x1F759D0", Length = "0x70")]
	[Token(Token = "0x6002736")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x1F76640", Offset = "0x1F75A40", Length = "0x172")]
	[Token(Token = "0x6002737")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F767C0", Offset = "0x1F75BC0", Length = "0x6D")]
	[Token(Token = "0x6002738")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x1F76830", Offset = "0x1F75C30", Length = "0x1BE")]
	[Token(Token = "0x6002739")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F769F0", Offset = "0x1F75DF0", Length = "0xEB")]
	[OnDeserialized]
	[Token(Token = "0x6002727")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x1F77210", Offset = "0x1F76610", Length = "0x10C")]
	[Token(Token = "0x600273D")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x1F76AE0", Offset = "0x1F75EE0", Length = "0xD8")]
	[Token(Token = "0x600273A")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F76BC0", Offset = "0x1F75FC0", Length = "0x16B")]
	[Token(Token = "0x600273E")]
	public virtual int ToFourDigitYear(int year) { }

	[Address(RVA = "0x1F76D30", Offset = "0x1F76130", Length = "0xFA")]
	[Token(Token = "0x600273B")]
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

}

