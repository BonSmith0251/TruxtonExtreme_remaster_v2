namespace System;

[IsReadOnly]
[Token(Token = "0x200013E")]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
{
	[Token(Token = "0x400044F")]
	public static readonly TimeSpan Zero; //Field offset: 0x0
	[Token(Token = "0x4000450")]
	public static readonly TimeSpan MaxValue; //Field offset: 0x8
	[Token(Token = "0x4000451")]
	public static readonly TimeSpan MinValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000452")]
	internal readonly long _ticks; //Field offset: 0x0

	[Token(Token = "0x170000A5")]
	public int Days
	{
		[Address(RVA = "0x204E620", Offset = "0x204DA20", Length = "0x13")]
		[Token(Token = "0x6000A4A")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000A6")]
	public int Hours
	{
		[Address(RVA = "0x204E640", Offset = "0x204DA40", Length = "0x3F")]
		[Token(Token = "0x6000A4B")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170000A7")]
	public int Minutes
	{
		[Address(RVA = "0x204E680", Offset = "0x204DA80", Length = "0x47")]
		[Token(Token = "0x6000A4C")]
		 get { } //Length: 71
	}

	[Token(Token = "0x170000A4")]
	public long Ticks
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000A49")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000A8")]
	public double TotalDays
	{
		[Address(RVA = "0x204E6D0", Offset = "0x204DAD0", Length = "0x11")]
		[Token(Token = "0x6000A4D")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000A9")]
	public double TotalHours
	{
		[Address(RVA = "0x204E6F0", Offset = "0x204DAF0", Length = "0x11")]
		[Token(Token = "0x6000A4E")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000AA")]
	public double TotalMilliseconds
	{
		[Address(RVA = "0x204E710", Offset = "0x204DB10", Length = "0x30")]
		[Token(Token = "0x6000A4F")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170000AB")]
	public double TotalMinutes
	{
		[Address(RVA = "0x204E740", Offset = "0x204DB40", Length = "0x11")]
		[Token(Token = "0x6000A50")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000AC")]
	public double TotalSeconds
	{
		[Address(RVA = "0x204E760", Offset = "0x204DB60", Length = "0x11")]
		[Token(Token = "0x6000A51")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x204E3F0", Offset = "0x204D7F0", Length = "0x72")]
	[Token(Token = "0x6000A71")]
	private static TimeSpan() { }

	[Address(RVA = "0x204E470", Offset = "0x204D870", Length = "0xB6")]
	[Token(Token = "0x6000A48")]
	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000A46")]
	public TimeSpan(long ticks) { }

	[Address(RVA = "0x204E530", Offset = "0x204D930", Length = "0xE4")]
	[Token(Token = "0x6000A47")]
	public TimeSpan(int hours, int minutes, int seconds) { }

	[Address(RVA = "0x204DA60", Offset = "0x204CE60", Length = "0x7B")]
	[Token(Token = "0x6000A52")]
	public TimeSpan Add(TimeSpan ts) { }

	[Address(RVA = "0x204DBF0", Offset = "0x204CFF0", Length = "0x16")]
	[Token(Token = "0x6000A53")]
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x204DB00", Offset = "0x204CF00", Length = "0xE4")]
	[Token(Token = "0x6000A54")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x204DAE0", Offset = "0x204CEE0", Length = "0x16")]
	[Token(Token = "0x6000A55")]
	public override int CompareTo(TimeSpan value) { }

	[Address(RVA = "0x204DC10", Offset = "0x204D010", Length = "0x81")]
	[Token(Token = "0x6000A57")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000A58")]
	public override bool Equals(TimeSpan obj) { }

	[Address(RVA = "0x204DCA0", Offset = "0x204D0A0", Length = "0x56")]
	[Token(Token = "0x6000A56")]
	public static TimeSpan FromDays(double value) { }

	[Address(RVA = "0x204DD00", Offset = "0x204D100", Length = "0x56")]
	[Token(Token = "0x6000A5A")]
	public static TimeSpan FromHours(double value) { }

	[Address(RVA = "0x204DD60", Offset = "0x204D160", Length = "0x56")]
	[Token(Token = "0x6000A5C")]
	public static TimeSpan FromMilliseconds(double value) { }

	[Address(RVA = "0x204DDC0", Offset = "0x204D1C0", Length = "0x56")]
	[Token(Token = "0x6000A5D")]
	public static TimeSpan FromMinutes(double value) { }

	[Address(RVA = "0x204DE20", Offset = "0x204D220", Length = "0x56")]
	[Token(Token = "0x6000A5F")]
	public static TimeSpan FromSeconds(double value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A61")]
	public static TimeSpan FromTicks(long value) { }

	[Address(RVA = "0x204E620", Offset = "0x204DA20", Length = "0x13")]
	[Token(Token = "0x6000A4A")]
	public int get_Days() { }

	[Address(RVA = "0x204E640", Offset = "0x204DA40", Length = "0x3F")]
	[Token(Token = "0x6000A4B")]
	public int get_Hours() { }

	[Address(RVA = "0x204E680", Offset = "0x204DA80", Length = "0x47")]
	[Token(Token = "0x6000A4C")]
	public int get_Minutes() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000A49")]
	public long get_Ticks() { }

	[Address(RVA = "0x204E6D0", Offset = "0x204DAD0", Length = "0x11")]
	[Token(Token = "0x6000A4D")]
	public double get_TotalDays() { }

	[Address(RVA = "0x204E6F0", Offset = "0x204DAF0", Length = "0x11")]
	[Token(Token = "0x6000A4E")]
	public double get_TotalHours() { }

	[Address(RVA = "0x204E710", Offset = "0x204DB10", Length = "0x30")]
	[Token(Token = "0x6000A4F")]
	public double get_TotalMilliseconds() { }

	[Address(RVA = "0x204E740", Offset = "0x204DB40", Length = "0x11")]
	[Token(Token = "0x6000A50")]
	public double get_TotalMinutes() { }

	[Address(RVA = "0x204E760", Offset = "0x204DB60", Length = "0x11")]
	[Token(Token = "0x6000A51")]
	public double get_TotalSeconds() { }

	[Address(RVA = "0x2028290", Offset = "0x2027690", Length = "0xA")]
	[Token(Token = "0x6000A59")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x204DE80", Offset = "0x204D280", Length = "0x10D")]
	[Token(Token = "0x6000A5B")]
	private static TimeSpan Interval(double value, int scale) { }

	[Address(RVA = "0x204DF90", Offset = "0x204D390", Length = "0xA8")]
	[Token(Token = "0x6000A5E")]
	public TimeSpan Negate() { }

	[Address(RVA = "0x204E780", Offset = "0x204DB80", Length = "0xB5")]
	[Token(Token = "0x6000A6A")]
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000A6B")]
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x204E850", Offset = "0x204DC50", Length = "0x7")]
	[Token(Token = "0x6000A6F")]
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x204E840", Offset = "0x204DC40", Length = "0x7")]
	[Token(Token = "0x6000A70")]
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000A6C")]
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x204E870", Offset = "0x204DC70", Length = "0x7")]
	[Token(Token = "0x6000A6D")]
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x204E860", Offset = "0x204DC60", Length = "0x7")]
	[Token(Token = "0x6000A6E")]
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x204E880", Offset = "0x204DC80", Length = "0xB7")]
	[Token(Token = "0x6000A69")]
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x204E940", Offset = "0x204DD40", Length = "0xA5")]
	[Token(Token = "0x6000A68")]
	public static TimeSpan op_UnaryNegation(TimeSpan t) { }

	[Address(RVA = "0x204E040", Offset = "0x204D440", Length = "0x81")]
	[Token(Token = "0x6000A64")]
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	[Address(RVA = "0x204E0D0", Offset = "0x204D4D0", Length = "0x74")]
	[Token(Token = "0x6000A63")]
	public static TimeSpan Parse(string s) { }

	[Address(RVA = "0x204E150", Offset = "0x204D550", Length = "0x7B")]
	[Token(Token = "0x6000A60")]
	public TimeSpan Subtract(TimeSpan ts) { }

	[Address(RVA = "0x204E1D0", Offset = "0x204D5D0", Length = "0x97")]
	[Token(Token = "0x6000A62")]
	internal static long TimeToTicks(int hour, int minute, int second) { }

	[Address(RVA = "0x204E2D0", Offset = "0x204D6D0", Length = "0x6C")]
	[Token(Token = "0x6000A66")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x204E270", Offset = "0x204D670", Length = "0x52")]
	[Token(Token = "0x6000A65")]
	public virtual string ToString() { }

	[Address(RVA = "0x204E340", Offset = "0x204D740", Length = "0xA5")]
	[Token(Token = "0x6000A67")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

}

