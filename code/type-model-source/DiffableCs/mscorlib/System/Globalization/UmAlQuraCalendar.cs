namespace System.Globalization;

[Token(Token = "0x200056E")]
public class UmAlQuraCalendar : Calendar
{
	[Token(Token = "0x200056F")]
	public struct DateMapping
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40016BB")]
		internal int HijriMonthsLengthFlags; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40016BC")]
		internal DateTime GregorianDate; //Field offset: 0x8

		[Address(RVA = "0x1FAF990", Offset = "0x1FAED90", Length = "0x41")]
		[Token(Token = "0x6002829")]
		internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay) { }

	}

	[Token(Token = "0x40016B8")]
	private static readonly DateMapping[] HijriYearInfo; //Field offset: 0x0
	[Token(Token = "0x40016B9")]
	internal static DateTime minDate; //Field offset: 0x8
	[Token(Token = "0x40016BA")]
	internal static DateTime maxDate; //Field offset: 0x10

	[Token(Token = "0x170005C6")]
	internal virtual int BaseCalendarID
	{
		[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
		[Token(Token = "0x600280F")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170005C8")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x1F89070", Offset = "0x1F88470", Length = "0x53")]
		[Token(Token = "0x600281F")]
		 get { } //Length: 83
	}

	[Token(Token = "0x170005C7")]
	internal virtual int ID
	{
		[Address(RVA = "0x1F890D0", Offset = "0x1F884D0", Length = "0x6")]
		[Token(Token = "0x6002810")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170005C5")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x1F890E0", Offset = "0x1F884E0", Length = "0x4F")]
		[Token(Token = "0x600280D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170005C4")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x1F89130", Offset = "0x1F88530", Length = "0x4F")]
		[Token(Token = "0x600280C")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170005C9")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x1F79460", Offset = "0x1F78860", Length = "0x6C")]
		[Token(Token = "0x6002825")]
		 get { } //Length: 108
		[Address(RVA = "0x1F89180", Offset = "0x1F88580", Length = "0x16F")]
		[Token(Token = "0x6002826")]
		 set { } //Length: 367
	}

	[Address(RVA = "0x1F88D80", Offset = "0x1F88180", Length = "0x2E2")]
	[Token(Token = "0x6002828")]
	private static UmAlQuraCalendar() { }

	[Address(RVA = "0x1F71DD0", Offset = "0x1F711D0", Length = "0x15")]
	[Token(Token = "0x600280E")]
	public UmAlQuraCalendar() { }

	[Address(RVA = "0x1F87710", Offset = "0x1F86B10", Length = "0x86")]
	[Token(Token = "0x6002814")]
	internal static void CheckEraRange(int era) { }

	[Address(RVA = "0x1F877A0", Offset = "0x1F86BA0", Length = "0x1FD")]
	[Token(Token = "0x6002813")]
	internal static void CheckTicksRange(long ticks) { }

	[Address(RVA = "0x1F879A0", Offset = "0x1F86DA0", Length = "0xCF")]
	[Token(Token = "0x6002816")]
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	[Address(RVA = "0x1F87A70", Offset = "0x1F86E70", Length = "0x1A2")]
	[Token(Token = "0x6002815")]
	internal static void CheckYearRange(int year, int era) { }

	[Address(RVA = "0x1F87C20", Offset = "0x1F87020", Length = "0x311")]
	[Token(Token = "0x6002817")]
	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay) { }

	[Address(RVA = "0x1F87F40", Offset = "0x1F87340", Length = "0x16B")]
	[Token(Token = "0x6002811")]
	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg) { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x600280F")]
	internal virtual int get_BaseCalendarID() { }

	[Address(RVA = "0x1F89070", Offset = "0x1F88470", Length = "0x53")]
	[Token(Token = "0x600281F")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x1F890D0", Offset = "0x1F884D0", Length = "0x6")]
	[Token(Token = "0x6002810")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x1F890E0", Offset = "0x1F884E0", Length = "0x4F")]
	[Token(Token = "0x600280D")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x1F89130", Offset = "0x1F88530", Length = "0x4F")]
	[Token(Token = "0x600280C")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x1F79460", Offset = "0x1F78860", Length = "0x6C")]
	[Token(Token = "0x6002825")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x1F880B0", Offset = "0x1F874B0", Length = "0x1B9")]
	[Token(Token = "0x6002812")]
	private static long GetAbsoluteDateUmAlQura(int year, int month, int day) { }

	[Address(RVA = "0x1F88270", Offset = "0x1F87670", Length = "0x1AD")]
	[Token(Token = "0x6002818")]
	internal override int GetDatePart(DateTime time, int part) { }

	[Address(RVA = "0x1F88420", Offset = "0x1F87820", Length = "0x1A")]
	[Token(Token = "0x6002819")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x1F88440", Offset = "0x1F87840", Length = "0x7C")]
	[Token(Token = "0x600281A")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x1F884C0", Offset = "0x1F878C0", Length = "0xB2")]
	[Token(Token = "0x600281B")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x1F88580", Offset = "0x1F87980", Length = "0x5F")]
	[Token(Token = "0x600281D")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x1F885E0", Offset = "0x1F879E0", Length = "0x80")]
	[Token(Token = "0x600281E")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x1F88660", Offset = "0x1F87A60", Length = "0x1A")]
	[Token(Token = "0x6002820")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x1F88680", Offset = "0x1F87A80", Length = "0x5C")]
	[Token(Token = "0x6002821")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x1F886E0", Offset = "0x1F87AE0", Length = "0x17")]
	[Token(Token = "0x6002822")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x1F88700", Offset = "0x1F87B00", Length = "0x172")]
	[Token(Token = "0x600280B")]
	private static DateMapping[] InitDateMapping() { }

	[Address(RVA = "0x1F88880", Offset = "0x1F87C80", Length = "0x68")]
	[Token(Token = "0x6002823")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x1F888F0", Offset = "0x1F87CF0", Length = "0x9D")]
	[Token(Token = "0x600281C")]
	internal static int RealGetDaysInYear(int year) { }

	[Address(RVA = "0x1F89180", Offset = "0x1F88580", Length = "0x16F")]
	[Token(Token = "0x6002826")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x1F88990", Offset = "0x1F87D90", Length = "0x25F")]
	[Token(Token = "0x6002824")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x1F88BF0", Offset = "0x1F87FF0", Length = "0x186")]
	[Token(Token = "0x6002827")]
	public virtual int ToFourDigitYear(int year) { }

}

