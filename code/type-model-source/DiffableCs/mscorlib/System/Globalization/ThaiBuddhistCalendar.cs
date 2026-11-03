namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200056D")]
public class ThaiBuddhistCalendar : Calendar
{
	[Token(Token = "0x40016B6")]
	internal static EraInfo[] thaiBuddhistEraInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016B7")]
	internal GregorianCalendarHelper helper; //Field offset: 0x20

	[Token(Token = "0x170005C2")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x1F7A3A0", Offset = "0x1F797A0", Length = "0x1D")]
		[Token(Token = "0x6002806")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170005C1")]
	internal virtual int ID
	{
		[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
		[Token(Token = "0x60027FB")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x170005C0")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x1F7E850", Offset = "0x1F7DC50", Length = "0x4F")]
		[Token(Token = "0x60027F9")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x170005BF")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x1F7E8A0", Offset = "0x1F7DCA0", Length = "0x4F")]
		[Token(Token = "0x60027F8")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170005C3")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x1F7E8F0", Offset = "0x1F7DCF0", Length = "0x6C")]
		[Token(Token = "0x6002807")]
		 get { } //Length: 108
		[Address(RVA = "0x1F7E960", Offset = "0x1F7DD60", Length = "0x133")]
		[Token(Token = "0x6002808")]
		 set { } //Length: 307
	}

	[Address(RVA = "0x1F7E670", Offset = "0x1F7DA70", Length = "0x11D")]
	[Token(Token = "0x600280A")]
	private static ThaiBuddhistCalendar() { }

	[Address(RVA = "0x1F7E790", Offset = "0x1F7DB90", Length = "0xBA")]
	[Token(Token = "0x60027FA")]
	public ThaiBuddhistCalendar() { }

	[Address(RVA = "0x1F7A3A0", Offset = "0x1F797A0", Length = "0x1D")]
	[Token(Token = "0x6002806")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
	[Token(Token = "0x60027FB")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x1F7E850", Offset = "0x1F7DC50", Length = "0x4F")]
	[Token(Token = "0x60027F9")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x1F7E8A0", Offset = "0x1F7DCA0", Length = "0x4F")]
	[Token(Token = "0x60027F8")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x1F7E8F0", Offset = "0x1F7DCF0", Length = "0x6C")]
	[Token(Token = "0x6002807")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x1F797C0", Offset = "0x1F78BC0", Length = "0x1E")]
	[Token(Token = "0x60027FE")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x1F797E0", Offset = "0x1F78BE0", Length = "0x1E")]
	[Token(Token = "0x60027FF")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x1F79800", Offset = "0x1F78C00", Length = "0x24")]
	[Token(Token = "0x60027FC")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F79830", Offset = "0x1F78C30", Length = "0x1E")]
	[Token(Token = "0x60027FD")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x1F79F20", Offset = "0x1F79320", Length = "0x1E")]
	[Token(Token = "0x6002801")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x1F79F40", Offset = "0x1F79340", Length = "0x1E")]
	[Token(Token = "0x6002802")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x1F79F60", Offset = "0x1F79360", Length = "0x2D")]
	[Token(Token = "0x6002800")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F79F90", Offset = "0x1F79390", Length = "0x1E")]
	[Token(Token = "0x6002803")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x1F79FB0", Offset = "0x1F793B0", Length = "0x1E")]
	[Token(Token = "0x6002804")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F7E960", Offset = "0x1F7DD60", Length = "0x133")]
	[Token(Token = "0x6002808")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x1F7A000", Offset = "0x1F79400", Length = "0x27")]
	[Token(Token = "0x6002805")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F7E5B0", Offset = "0x1F7D9B0", Length = "0xB0")]
	[Token(Token = "0x6002809")]
	public virtual int ToFourDigitYear(int year) { }

}

