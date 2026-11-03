namespace System.Xml.Schema;

[Token(Token = "0x200026E")]
internal struct XsdDuration
{
	[Token(Token = "0x2000270")]
	internal enum DurationType : int
	{
		Duration = 0,
		YearMonthDuration = 1,
		DayTimeDuration = 2,
	}

	[Token(Token = "0x200026F")]
	private enum Parts : int
	{
		HasNone = 0,
		HasYears = 1,
		HasMonths = 2,
		HasDays = 4,
		HasHours = 8,
		HasMinutes = 16,
		HasSeconds = 32,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D9B")]
	private int years; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D9C")]
	private int months; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D9D")]
	private int days; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000D9E")]
	private int hours; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D9F")]
	private int minutes; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000DA0")]
	private int seconds; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DA1")]
	private uint nanoseconds; //Field offset: 0x18

	[Token(Token = "0x1700068B")]
	public int Days
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x600194B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700068C")]
	public int Hours
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x600194C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000688")]
	public bool IsNegative
	{
		[Address(RVA = "0x24E4200", Offset = "0x24E3600", Length = "0xB")]
		[Token(Token = "0x6001948")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700068D")]
	public int Minutes
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600194D")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700068A")]
	public int Months
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x600194A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700068F")]
	public int Nanoseconds
	{
		[Address(RVA = "0x24E4210", Offset = "0x24E3610", Length = "0x8")]
		[Token(Token = "0x600194F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700068E")]
	public int Seconds
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600194E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000689")]
	public int Years
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6001949")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x24E3F60", Offset = "0x24E3360", Length = "0x28F")]
	[Token(Token = "0x6001943")]
	public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	[Address(RVA = "0x24E3C30", Offset = "0x24E3030", Length = "0xB")]
	[Token(Token = "0x6001944")]
	public XsdDuration(TimeSpan timeSpan) { }

	[Address(RVA = "0x24E3C40", Offset = "0x24E3040", Length = "0x260")]
	[Token(Token = "0x6001945")]
	public XsdDuration(TimeSpan timeSpan, DurationType durationType) { }

	[Address(RVA = "0x24E41F0", Offset = "0x24E35F0", Length = "0xB")]
	[Token(Token = "0x6001946")]
	public XsdDuration(string s) { }

	[Address(RVA = "0x24E3EB0", Offset = "0x24E32B0", Length = "0xA7")]
	[Token(Token = "0x6001947")]
	public XsdDuration(string s, DurationType durationType) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x600194B")]
	public int get_Days() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x600194C")]
	public int get_Hours() { }

	[Address(RVA = "0x24E4200", Offset = "0x24E3600", Length = "0xB")]
	[Token(Token = "0x6001948")]
	public bool get_IsNegative() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600194D")]
	public int get_Minutes() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x600194A")]
	public int get_Months() { }

	[Address(RVA = "0x24E4210", Offset = "0x24E3610", Length = "0x8")]
	[Token(Token = "0x600194F")]
	public int get_Nanoseconds() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x600194E")]
	public int get_Seconds() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6001949")]
	public int get_Years() { }

	[Address(RVA = "0x24E2460", Offset = "0x24E1860", Length = "0xA")]
	[Token(Token = "0x6001954")]
	public virtual string ToString() { }

	[Address(RVA = "0x24E2470", Offset = "0x24E1870", Length = "0x3E2")]
	[Token(Token = "0x6001955")]
	internal string ToString(DurationType durationType) { }

	[Address(RVA = "0x24E2860", Offset = "0x24E1C60", Length = "0x48")]
	[Token(Token = "0x6001950")]
	public TimeSpan ToTimeSpan() { }

	[Address(RVA = "0x24E28B0", Offset = "0x24E1CB0", Length = "0x46")]
	[Token(Token = "0x6001951")]
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	[Address(RVA = "0x24E2A60", Offset = "0x24E1E60", Length = "0xB98")]
	[Token(Token = "0x6001957")]
	internal static Exception TryParse(string s, DurationType durationType, out XsdDuration result) { }

	[Address(RVA = "0x24E2A50", Offset = "0x24E1E50", Length = "0xD")]
	[Token(Token = "0x6001956")]
	internal static Exception TryParse(string s, out XsdDuration result) { }

	[Address(RVA = "0x24E2900", Offset = "0x24E1D00", Length = "0x14E")]
	[Token(Token = "0x6001958")]
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

	[Address(RVA = "0x24E3600", Offset = "0x24E2A00", Length = "0xD")]
	[Token(Token = "0x6001952")]
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	[Address(RVA = "0x24E3610", Offset = "0x24E2A10", Length = "0x61C")]
	[Token(Token = "0x6001953")]
	internal Exception TryToTimeSpan(DurationType durationType, out TimeSpan result) { }

}

