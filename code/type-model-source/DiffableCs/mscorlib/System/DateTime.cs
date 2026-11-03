namespace System;

[IsReadOnly]
[Token(Token = "0x20000C8")]
public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
{
	[Token(Token = "0x40002B6")]
	private const long TicksPerMillisecond = 10000; //Field offset: 0x0
	[Token(Token = "0x40002E3")]
	private const string DateDataField = "dateData"; //Field offset: 0x0
	[Token(Token = "0x40002CE")]
	private const double OADateMinAsDouble = -657435; //Field offset: 0x0
	[Token(Token = "0x40002CF")]
	private const double OADateMaxAsDouble = 2958466; //Field offset: 0x0
	[Token(Token = "0x40002D0")]
	private const int DatePartYear = 0; //Field offset: 0x0
	[Token(Token = "0x40002D1")]
	private const int DatePartDayOfYear = 1; //Field offset: 0x0
	[Token(Token = "0x40002D2")]
	private const int DatePartMonth = 2; //Field offset: 0x0
	[Token(Token = "0x40002D3")]
	private const int DatePartDay = 3; //Field offset: 0x0
	[Token(Token = "0x40002D4")]
	private static readonly Int32[] s_daysToMonth365; //Field offset: 0x0
	[Token(Token = "0x40002CC")]
	private const long DoubleDateOffset = 599264352000000000; //Field offset: 0x0
	[Token(Token = "0x40002D9")]
	private const ulong TicksMask = 4611686018427387903; //Field offset: 0x0
	[Token(Token = "0x40002DB")]
	private const ulong LocalMask = 9223372036854775808; //Field offset: 0x0
	[Token(Token = "0x40002DC")]
	private const long TicksCeiling = 4611686018427387904; //Field offset: 0x0
	[Token(Token = "0x40002DD")]
	private const ulong KindUnspecified = 0; //Field offset: 0x0
	[Token(Token = "0x40002DE")]
	private const ulong KindUtc = 4611686018427387904; //Field offset: 0x0
	[Token(Token = "0x40002DF")]
	private const ulong KindLocal = 9223372036854775808; //Field offset: 0x0
	[Token(Token = "0x40002E0")]
	private const ulong KindLocalAmbiguousDst = 13835058055282163712; //Field offset: 0x0
	[Token(Token = "0x40002E1")]
	private const int KindShift = 62; //Field offset: 0x0
	[Token(Token = "0x40002E2")]
	private const string TicksField = "ticks"; //Field offset: 0x0
	[Token(Token = "0x40002DA")]
	private const ulong FlagsMask = 13835058055282163712; //Field offset: 0x0
	[Token(Token = "0x40002CB")]
	private const long FileTimeOffset = 504911232000000000; //Field offset: 0x0
	[Token(Token = "0x40002CD")]
	private const long OADateMinAsTicks = 31241376000000000; //Field offset: 0x0
	[Token(Token = "0x40002C9")]
	private const long MaxMillis = 315537897600000; //Field offset: 0x0
	[Token(Token = "0x40002B9")]
	private const long TicksPerHour = 36000000000; //Field offset: 0x0
	[Token(Token = "0x40002BA")]
	private const long TicksPerDay = 864000000000; //Field offset: 0x0
	[Token(Token = "0x40002BB")]
	private const int MillisPerSecond = 1000; //Field offset: 0x0
	[Token(Token = "0x40002BC")]
	private const int MillisPerMinute = 60000; //Field offset: 0x0
	[Token(Token = "0x40002BD")]
	private const int MillisPerHour = 3600000; //Field offset: 0x0
	[Token(Token = "0x40002BE")]
	private const int MillisPerDay = 86400000; //Field offset: 0x0
	[Token(Token = "0x40002BF")]
	private const int DaysPerYear = 365; //Field offset: 0x0
	[Token(Token = "0x40002C0")]
	private const int DaysPer4Years = 1461; //Field offset: 0x0
	[Token(Token = "0x40002CA")]
	internal const long UnixEpochTicks = 621355968000000000; //Field offset: 0x0
	[Token(Token = "0x40002B8")]
	private const long TicksPerMinute = 600000000; //Field offset: 0x0
	[Token(Token = "0x40002B7")]
	private const long TicksPerSecond = 10000000; //Field offset: 0x0
	[Token(Token = "0x40002C1")]
	private const int DaysPer100Years = 36524; //Field offset: 0x0
	[Token(Token = "0x40002C2")]
	private const int DaysPer400Years = 146097; //Field offset: 0x0
	[Token(Token = "0x40002C3")]
	private const int DaysTo1601 = 584388; //Field offset: 0x0
	[Token(Token = "0x40002C4")]
	private const int DaysTo1899 = 693593; //Field offset: 0x0
	[Token(Token = "0x40002C5")]
	internal const int DaysTo1970 = 719162; //Field offset: 0x0
	[Token(Token = "0x40002C6")]
	private const int DaysTo10000 = 3652059; //Field offset: 0x0
	[Token(Token = "0x40002C7")]
	internal const long MinTicks = 0; //Field offset: 0x0
	[Token(Token = "0x40002C8")]
	internal const long MaxTicks = 3155378975999999999; //Field offset: 0x0
	[Token(Token = "0x40002D5")]
	private static readonly Int32[] s_daysToMonth366; //Field offset: 0x8
	[Token(Token = "0x40002D6")]
	public static readonly DateTime MinValue; //Field offset: 0x10
	[Token(Token = "0x40002D7")]
	public static readonly DateTime MaxValue; //Field offset: 0x18
	[Token(Token = "0x40002D8")]
	public static readonly DateTime UnixEpoch; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E4")]
	private readonly ulong _dateData; //Field offset: 0x0

	[Token(Token = "0x17000061")]
	public DateTime Date
	{
		[Address(RVA = "0x201EFE0", Offset = "0x201E3E0", Length = "0x78")]
		[Token(Token = "0x60005F9")]
		 get { } //Length: 120
	}

	[Token(Token = "0x17000062")]
	public int Day
	{
		[Address(RVA = "0x201F0F0", Offset = "0x201E4F0", Length = "0x4F")]
		[Token(Token = "0x60005FC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000063")]
	public DayOfWeek DayOfWeek
	{
		[Address(RVA = "0x201F060", Offset = "0x201E460", Length = "0x86")]
		[Token(Token = "0x60005FD")]
		 get { } //Length: 134
	}

	[Token(Token = "0x17000064")]
	public int Hour
	{
		[Address(RVA = "0x201F140", Offset = "0x201E540", Length = "0x8B")]
		[Token(Token = "0x60005FF")]
		 get { } //Length: 139
	}

	[Token(Token = "0x17000060")]
	private ulong InternalKind
	{
		[Address(RVA = "0x201F1D0", Offset = "0x201E5D0", Length = "0x11")]
		[Token(Token = "0x60005E1")]
		private get { } //Length: 17
	}

	[Token(Token = "0x1700005F")]
	internal long InternalTicks
	{
		[Address(RVA = "0x201F1F0", Offset = "0x201E5F0", Length = "0x11")]
		[Token(Token = "0x60005E0")]
		internal get { } //Length: 17
	}

	[Token(Token = "0x17000065")]
	public DateTimeKind Kind
	{
		[Address(RVA = "0x201F210", Offset = "0x201E610", Length = "0x6E")]
		[Token(Token = "0x6000601")]
		 get { } //Length: 110
	}

	[Token(Token = "0x17000066")]
	public int Millisecond
	{
		[Address(RVA = "0x201F280", Offset = "0x201E680", Length = "0x8C")]
		[Token(Token = "0x6000602")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000067")]
	public int Minute
	{
		[Address(RVA = "0x201F310", Offset = "0x201E710", Length = "0x8C")]
		[Token(Token = "0x6000603")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000068")]
	public int Month
	{
		[Address(RVA = "0x201F3A0", Offset = "0x201E7A0", Length = "0x4F")]
		[Token(Token = "0x6000604")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000069")]
	public static DateTime Now
	{
		[Address(RVA = "0x201F3F0", Offset = "0x201E7F0", Length = "0x182")]
		[Token(Token = "0x6000605")]
		 get { } //Length: 386
	}

	[Token(Token = "0x1700006A")]
	public int Second
	{
		[Address(RVA = "0x201F580", Offset = "0x201E980", Length = "0x8C")]
		[Token(Token = "0x6000606")]
		 get { } //Length: 140
	}

	[Token(Token = "0x1700006B")]
	public long Ticks
	{
		[Address(RVA = "0x201F610", Offset = "0x201EA10", Length = "0x50")]
		[Token(Token = "0x6000607")]
		 get { } //Length: 80
	}

	[Token(Token = "0x1700006C")]
	public TimeSpan TimeOfDay
	{
		[Address(RVA = "0x201F660", Offset = "0x201EA60", Length = "0x62")]
		[Token(Token = "0x6000608")]
		 get { } //Length: 98
	}

	[Token(Token = "0x1700006E")]
	public static DateTime UtcNow
	{
		[Address(RVA = "0x201F6D0", Offset = "0x201EAD0", Length = "0x59")]
		[Token(Token = "0x6000638")]
		 get { } //Length: 89
	}

	[Token(Token = "0x1700006D")]
	public int Year
	{
		[Address(RVA = "0x201F730", Offset = "0x201EB30", Length = "0x4C")]
		[Token(Token = "0x6000609")]
		 get { } //Length: 76
	}

	[Address(RVA = "0x201E310", Offset = "0x201D710", Length = "0x139")]
	[Token(Token = "0x600063B")]
	private static DateTime() { }

	[Address(RVA = "0x201E4F0", Offset = "0x201D8F0", Length = "0x2F3")]
	[Token(Token = "0x60005DF")]
	private DateTime(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x201E880", Offset = "0x201DC80", Length = "0x27A")]
	[Token(Token = "0x60005DE")]
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

	[Address(RVA = "0x201EC20", Offset = "0x201E020", Length = "0x1B6")]
	[Token(Token = "0x60005DD")]
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	[Address(RVA = "0x201EDE0", Offset = "0x201E1E0", Length = "0x10C")]
	[Token(Token = "0x60005DC")]
	public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	[Address(RVA = "0x201E7F0", Offset = "0x201DBF0", Length = "0x89")]
	[Token(Token = "0x60005D6")]
	public DateTime(long ticks) { }

	[Address(RVA = "0x201EBA0", Offset = "0x201DFA0", Length = "0x79")]
	[Token(Token = "0x60005DA")]
	public DateTime(int year, int month, int day) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x60005D7")]
	private DateTime(ulong dateData) { }

	[Address(RVA = "0x201E450", Offset = "0x201D850", Length = "0x94")]
	[Token(Token = "0x60005DB")]
	public DateTime(int year, int month, int day, int hour, int minute, int second) { }

	[Address(RVA = "0x201EB00", Offset = "0x201DF00", Length = "0x98")]
	[Token(Token = "0x60005D9")]
	internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	[Address(RVA = "0x201EEF0", Offset = "0x201E2F0", Length = "0xEC")]
	[Token(Token = "0x60005D8")]
	public DateTime(long ticks, DateTimeKind kind) { }

	[Address(RVA = "0x201AEE0", Offset = "0x201A2E0", Length = "0x59")]
	[Token(Token = "0x60005E2")]
	public DateTime Add(TimeSpan value) { }

	[Address(RVA = "0x201ADC0", Offset = "0x201A1C0", Length = "0x110")]
	[Token(Token = "0x60005E3")]
	private DateTime Add(double value, int scale) { }

	[Address(RVA = "0x201A750", Offset = "0x2019B50", Length = "0x60")]
	[Token(Token = "0x60005E4")]
	public DateTime AddDays(double value) { }

	[Address(RVA = "0x201A7B0", Offset = "0x2019BB0", Length = "0x60")]
	[Token(Token = "0x60005E5")]
	public DateTime AddMilliseconds(double value) { }

	[Address(RVA = "0x201A810", Offset = "0x2019C10", Length = "0x360")]
	[Token(Token = "0x60005E6")]
	public DateTime AddMonths(int months) { }

	[Address(RVA = "0x201AB80", Offset = "0x2019F80", Length = "0x60")]
	[Token(Token = "0x60005E7")]
	public DateTime AddSeconds(double value) { }

	[Address(RVA = "0x201ABE0", Offset = "0x2019FE0", Length = "0x109")]
	[Token(Token = "0x60005E8")]
	public DateTime AddTicks(long value) { }

	[Address(RVA = "0x201ACF0", Offset = "0x201A0F0", Length = "0xC2")]
	[Token(Token = "0x60005E9")]
	public DateTime AddYears(int value) { }

	[Address(RVA = "0x201B090", Offset = "0x201A490", Length = "0x73")]
	[Token(Token = "0x60005EA")]
	public static int Compare(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x201AF40", Offset = "0x201A340", Length = "0xEC")]
	[Token(Token = "0x60005EB")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x201B030", Offset = "0x201A430", Length = "0x5C")]
	[Token(Token = "0x60005EC")]
	public override int CompareTo(DateTime value) { }

	[Address(RVA = "0x201B110", Offset = "0x201A510", Length = "0x1C4")]
	[Token(Token = "0x60005ED")]
	private static long DateToTicks(int year, int month, int day) { }

	[Address(RVA = "0x201B2E0", Offset = "0x201A6E0", Length = "0x137")]
	[Token(Token = "0x60005EF")]
	public static int DaysInMonth(int year, int month) { }

	[Address(RVA = "0x201B420", Offset = "0x201A820", Length = "0xB6")]
	[Token(Token = "0x60005F0")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x201B4E0", Offset = "0x201A8E0", Length = "0x5F")]
	[Token(Token = "0x60005F1")]
	public override bool Equals(DateTime value) { }

	[Address(RVA = "0x201B5E0", Offset = "0x201A9E0", Length = "0x2D2")]
	[Token(Token = "0x60005F2")]
	public static DateTime FromBinary(long dateData) { }

	[Address(RVA = "0x201B540", Offset = "0x201A940", Length = "0x99")]
	[Token(Token = "0x60005F3")]
	internal static DateTime FromBinaryRaw(long dateData) { }

	[Address(RVA = "0x201B980", Offset = "0x201AD80", Length = "0x126")]
	[Token(Token = "0x60005F4")]
	public static DateTime FromFileTime(long fileTime) { }

	[Address(RVA = "0x201B8C0", Offset = "0x201ACC0", Length = "0xB4")]
	[Token(Token = "0x60005F5")]
	public static DateTime FromFileTimeUtc(long fileTime) { }

	[Address(RVA = "0x201EFE0", Offset = "0x201E3E0", Length = "0x78")]
	[Token(Token = "0x60005F9")]
	public DateTime get_Date() { }

	[Address(RVA = "0x201F0F0", Offset = "0x201E4F0", Length = "0x4F")]
	[Token(Token = "0x60005FC")]
	public int get_Day() { }

	[Address(RVA = "0x201F060", Offset = "0x201E460", Length = "0x86")]
	[Token(Token = "0x60005FD")]
	public DayOfWeek get_DayOfWeek() { }

	[Address(RVA = "0x201F140", Offset = "0x201E540", Length = "0x8B")]
	[Token(Token = "0x60005FF")]
	public int get_Hour() { }

	[Address(RVA = "0x201F1D0", Offset = "0x201E5D0", Length = "0x11")]
	[Token(Token = "0x60005E1")]
	private ulong get_InternalKind() { }

	[Address(RVA = "0x201F1F0", Offset = "0x201E5F0", Length = "0x11")]
	[Token(Token = "0x60005E0")]
	internal long get_InternalTicks() { }

	[Address(RVA = "0x201F210", Offset = "0x201E610", Length = "0x6E")]
	[Token(Token = "0x6000601")]
	public DateTimeKind get_Kind() { }

	[Address(RVA = "0x201F280", Offset = "0x201E680", Length = "0x8C")]
	[Token(Token = "0x6000602")]
	public int get_Millisecond() { }

	[Address(RVA = "0x201F310", Offset = "0x201E710", Length = "0x8C")]
	[Token(Token = "0x6000603")]
	public int get_Minute() { }

	[Address(RVA = "0x201F3A0", Offset = "0x201E7A0", Length = "0x4F")]
	[Token(Token = "0x6000604")]
	public int get_Month() { }

	[Address(RVA = "0x201F3F0", Offset = "0x201E7F0", Length = "0x182")]
	[Token(Token = "0x6000605")]
	public static DateTime get_Now() { }

	[Address(RVA = "0x201F580", Offset = "0x201E980", Length = "0x8C")]
	[Token(Token = "0x6000606")]
	public int get_Second() { }

	[Address(RVA = "0x201F610", Offset = "0x201EA10", Length = "0x50")]
	[Token(Token = "0x6000607")]
	public long get_Ticks() { }

	[Address(RVA = "0x201F660", Offset = "0x201EA60", Length = "0x62")]
	[Token(Token = "0x6000608")]
	public TimeSpan get_TimeOfDay() { }

	[Address(RVA = "0x201F6D0", Offset = "0x201EAD0", Length = "0x59")]
	[Token(Token = "0x6000638")]
	public static DateTime get_UtcNow() { }

	[Address(RVA = "0x201F730", Offset = "0x201EB30", Length = "0x4C")]
	[Token(Token = "0x6000609")]
	public int get_Year() { }

	[Address(RVA = "0x201BCA0", Offset = "0x201B0A0", Length = "0x1E9")]
	[Token(Token = "0x60005FB")]
	internal void GetDatePart(out int year, out int month, out int day) { }

	[Address(RVA = "0x201BAB0", Offset = "0x201AEB0", Length = "0x1EB")]
	[Token(Token = "0x60005FA")]
	private int GetDatePart(int part) { }

	[Address(RVA = "0x201BE90", Offset = "0x201B290", Length = "0x59")]
	[Token(Token = "0x60005FE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x201BEF0", Offset = "0x201B2F0", Length = "0x5")]
	[Token(Token = "0x6000639")]
	internal static long GetSystemTimeAsFileTime() { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x6000627")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x201BF00", Offset = "0x201B300", Length = "0x56")]
	[Token(Token = "0x6000600")]
	internal bool IsAmbiguousDaylightSavingTime() { }

	[Address(RVA = "0x201BF60", Offset = "0x201B360", Length = "0xDE")]
	[Token(Token = "0x600060A")]
	public static bool IsLeapYear(int year) { }

	[Address(RVA = "0x201F780", Offset = "0x201EB80", Length = "0x106")]
	[Token(Token = "0x600061E")]
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	[Address(RVA = "0x201F890", Offset = "0x201EC90", Length = "0x5F")]
	[Token(Token = "0x6000621")]
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	[Address(RVA = "0x201F960", Offset = "0x201ED60", Length = "0x62")]
	[Token(Token = "0x6000625")]
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x201F8F0", Offset = "0x201ECF0", Length = "0x62")]
	[Token(Token = "0x6000626")]
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x201F9D0", Offset = "0x201EDD0", Length = "0x5F")]
	[Token(Token = "0x6000622")]
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	[Address(RVA = "0x201FAA0", Offset = "0x201EEA0", Length = "0x62")]
	[Token(Token = "0x6000623")]
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x201FA30", Offset = "0x201EE30", Length = "0x62")]
	[Token(Token = "0x6000624")]
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x201FC10", Offset = "0x201F010", Length = "0x62")]
	[Token(Token = "0x6000620")]
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	[Address(RVA = "0x201FB10", Offset = "0x201EF10", Length = "0xFF")]
	[Token(Token = "0x600061F")]
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	[Address(RVA = "0x201C7B0", Offset = "0x201BBB0", Length = "0xF7")]
	[Token(Token = "0x600060C")]
	public static DateTime Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x201C580", Offset = "0x201B980", Length = "0xE8")]
	[Token(Token = "0x600060B")]
	public static DateTime Parse(string s) { }

	[Address(RVA = "0x201C670", Offset = "0x201BA70", Length = "0x136")]
	[Token(Token = "0x600060D")]
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	[Address(RVA = "0x201C040", Offset = "0x201B440", Length = "0x319")]
	[Token(Token = "0x600060E")]
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	[Address(RVA = "0x201C360", Offset = "0x201B760", Length = "0x21F")]
	[Token(Token = "0x600060F")]
	public static DateTime ParseExact(string s, String[] formats, IFormatProvider provider, DateTimeStyles style) { }

	[Address(RVA = "0x201C8B0", Offset = "0x201BCB0", Length = "0x76")]
	[Token(Token = "0x60005F7")]
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	[Address(RVA = "0x201C930", Offset = "0x201BD30", Length = "0x62")]
	[Token(Token = "0x6000610")]
	public TimeSpan Subtract(DateTime value) { }

	[Address(RVA = "0x201C9A0", Offset = "0x201BDA0", Length = "0x84")]
	[Token(Token = "0x6000628")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x201CA30", Offset = "0x201BE30", Length = "0x84")]
	[Token(Token = "0x600062B")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x201CAC0", Offset = "0x201BEC0", Length = "0x84")]
	[Token(Token = "0x6000629")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000635")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x201CB50", Offset = "0x201BF50", Length = "0x84")]
	[Token(Token = "0x6000634")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x201CBE0", Offset = "0x201BFE0", Length = "0x84")]
	[Token(Token = "0x6000633")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x201CC70", Offset = "0x201C070", Length = "0x84")]
	[Token(Token = "0x600062C")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x201CD00", Offset = "0x201C100", Length = "0x84")]
	[Token(Token = "0x600062E")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x201CD90", Offset = "0x201C190", Length = "0x84")]
	[Token(Token = "0x6000630")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x201CE20", Offset = "0x201C220", Length = "0x84")]
	[Token(Token = "0x600062A")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x201CEB0", Offset = "0x201C2B0", Length = "0x84")]
	[Token(Token = "0x6000632")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x201CF40", Offset = "0x201C340", Length = "0x92")]
	[Token(Token = "0x6000636")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x201CFE0", Offset = "0x201C3E0", Length = "0x84")]
	[Token(Token = "0x600062D")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x201D070", Offset = "0x201C470", Length = "0x84")]
	[Token(Token = "0x600062F")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x201D100", Offset = "0x201C500", Length = "0x84")]
	[Token(Token = "0x6000631")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x201D190", Offset = "0x201C590", Length = "0xE7")]
	[Token(Token = "0x60005F6")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x201D280", Offset = "0x201C680", Length = "0xBE")]
	[Token(Token = "0x60005EE")]
	private static long TimeToTicks(int hour, int minute, int second) { }

	[Address(RVA = "0x201D340", Offset = "0x201C740", Length = "0x182")]
	[Token(Token = "0x60005F8")]
	public long ToBinary() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600063A")]
	internal long ToBinaryRaw() { }

	[Address(RVA = "0x201D760", Offset = "0x201CB60", Length = "0x4C")]
	[Token(Token = "0x6000611")]
	public DateTime ToLocalTime() { }

	[Address(RVA = "0x201D4D0", Offset = "0x201C8D0", Length = "0x281")]
	[Token(Token = "0x6000612")]
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	[Address(RVA = "0x201D7B0", Offset = "0x201CBB0", Length = "0x63")]
	[Token(Token = "0x6000613")]
	public string ToLongTimeString() { }

	[Address(RVA = "0x201D820", Offset = "0x201CC20", Length = "0x63")]
	[Token(Token = "0x6000614")]
	public string ToShortDateString() { }

	[Address(RVA = "0x201DA00", Offset = "0x201CE00", Length = "0x5F")]
	[Token(Token = "0x6000616")]
	public string ToString(string format) { }

	[Address(RVA = "0x201D900", Offset = "0x201CD00", Length = "0x9B")]
	[Token(Token = "0x6000615")]
	public virtual string ToString() { }

	[Address(RVA = "0x201D9A0", Offset = "0x201CDA0", Length = "0x5E")]
	[Token(Token = "0x6000617")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x201D890", Offset = "0x201CC90", Length = "0x6C")]
	[Token(Token = "0x6000618")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x201DA60", Offset = "0x201CE60", Length = "0x52")]
	[Token(Token = "0x600061A")]
	public DateTime ToUniversalTime() { }

	[Address(RVA = "0x201DAC0", Offset = "0x201CEC0", Length = "0x1FE")]
	[Token(Token = "0x6000637")]
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	[Address(RVA = "0x201DCC0", Offset = "0x201D0C0", Length = "0xEF")]
	[Token(Token = "0x6000619")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x201E0D0", Offset = "0x201D4D0", Length = "0xF1")]
	[Token(Token = "0x600061B")]
	public static bool TryParse(string s, out DateTime result) { }

	[Address(RVA = "0x201E1D0", Offset = "0x201D5D0", Length = "0x137")]
	[Token(Token = "0x600061C")]
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	[Address(RVA = "0x201DDB0", Offset = "0x201D1B0", Length = "0x31A")]
	[Token(Token = "0x600061D")]
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

}

