namespace System.Globalization;

[Token(Token = "0x2000565")]
internal class GregorianCalendarHelper
{
	[Token(Token = "0x400166B")]
	internal static readonly Int32[] DaysToMonth365; //Field offset: 0x0
	[Token(Token = "0x400166C")]
	internal static readonly Int32[] DaysToMonth366; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x400166D")]
	internal int m_maxYear; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x400166E")]
	internal int m_minYear; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400166F")]
	internal Calendar m_Cal; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x4001670")]
	internal EraInfo[] m_EraInfo; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x4001671")]
	internal Int32[] m_eras; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x4001672")]
	internal DateTime m_minDate; //Field offset: 0x30

	[Token(Token = "0x1700058C")]
	public Int32[] Eras
	{
		[Address(RVA = "0x1F759F0", Offset = "0x1F74DF0", Length = "0x136")]
		[Token(Token = "0x6002751")]
		 get { } //Length: 310
	}

	[Token(Token = "0x1700058B")]
	internal int MaxYear
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6002742")]
		internal get { } //Length: 85
	}

	[Address(RVA = "0x1F75840", Offset = "0x1F74C40", Length = "0xEA")]
	[Token(Token = "0x6002758")]
	private static GregorianCalendarHelper() { }

	[Address(RVA = "0x1F75930", Offset = "0x1F74D30", Length = "0xBD")]
	[Token(Token = "0x6002743")]
	internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo) { }

	[Address(RVA = "0x1F740E0", Offset = "0x1F734E0", Length = "0x204")]
	[Token(Token = "0x600274B")]
	internal void CheckTicksRange(long ticks) { }

	[Address(RVA = "0x1F742F0", Offset = "0x1F736F0", Length = "0x74")]
	[Token(Token = "0x6002749")]
	internal static long DateToTicks(int year, int month, int day) { }

	[Address(RVA = "0x1F759F0", Offset = "0x1F74DF0", Length = "0x136")]
	[Token(Token = "0x6002751")]
	public Int32[] get_Eras() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6002742")]
	internal int get_MaxYear() { }

	[Address(RVA = "0x1F74370", Offset = "0x1F73770", Length = "0x1EF")]
	[Token(Token = "0x6002748")]
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	[Address(RVA = "0x1F74560", Offset = "0x1F73960", Length = "0x1EF")]
	[Token(Token = "0x6002747")]
	internal override int GetDatePart(long ticks, int part) { }

	[Address(RVA = "0x1F74750", Offset = "0x1F73B50", Length = "0x70")]
	[Token(Token = "0x600274C")]
	public int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x1F747C0", Offset = "0x1F73BC0", Length = "0xA0")]
	[Token(Token = "0x600274D")]
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x1F74860", Offset = "0x1F73C60", Length = "0x1A6")]
	[Token(Token = "0x600274E")]
	public int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F74A10", Offset = "0x1F73E10", Length = "0x85")]
	[Token(Token = "0x600274F")]
	public int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x1F74AA0", Offset = "0x1F73EA0", Length = "0x107")]
	[Token(Token = "0x6002750")]
	public int GetEra(DateTime time) { }

	[Address(RVA = "0x1F74BB0", Offset = "0x1F73FB0", Length = "0x21")]
	[Token(Token = "0x6002745")]
	internal int GetGregorianYear(int year, int era) { }

	[Address(RVA = "0x1F74BE0", Offset = "0x1F73FE0", Length = "0x70")]
	[Token(Token = "0x6002752")]
	public int GetMonth(DateTime time) { }

	[Address(RVA = "0x1F74C50", Offset = "0x1F74050", Length = "0x1F")]
	[Token(Token = "0x6002753")]
	public int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F74FE0", Offset = "0x1F743E0", Length = "0x12B")]
	[Token(Token = "0x6002754")]
	public int GetYear(DateTime time) { }

	[Address(RVA = "0x1F74C70", Offset = "0x1F74070", Length = "0x364")]
	[Token(Token = "0x6002744")]
	private int GetYearOffset(int year, int era, bool throwOnError) { }

	[Address(RVA = "0x1F75110", Offset = "0x1F74510", Length = "0x79")]
	[Token(Token = "0x6002755")]
	public bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F75190", Offset = "0x1F74590", Length = "0x1F")]
	[Token(Token = "0x6002746")]
	internal bool IsValidYear(int year, int era) { }

	[Address(RVA = "0x1F751B0", Offset = "0x1F745B0", Length = "0x1BE")]
	[Token(Token = "0x600274A")]
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	[Address(RVA = "0x1F75370", Offset = "0x1F74770", Length = "0x2DF")]
	[Token(Token = "0x6002756")]
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F75650", Offset = "0x1F74A50", Length = "0x1EB")]
	[Token(Token = "0x6002757")]
	public int ToFourDigitYear(int year, int twoDigitYearMax) { }

}

