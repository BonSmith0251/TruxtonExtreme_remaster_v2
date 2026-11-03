namespace System;

[IsReadOnly]
[Token(Token = "0x20000CA")]
public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
{
	[Token(Token = "0x40002E9")]
	public static readonly DateTimeOffset MinValue; //Field offset: 0x0
	[Token(Token = "0x40002EA")]
	public static readonly DateTimeOffset MaxValue; //Field offset: 0x10
	[Token(Token = "0x40002EB")]
	public static readonly DateTimeOffset UnixEpoch; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002EC")]
	private readonly DateTime _dateTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002ED")]
	private readonly short _offsetMinutes; //Field offset: 0x8

	[Token(Token = "0x17000073")]
	private DateTime ClockDateTime
	{
		[Address(RVA = "0x200D780", Offset = "0x200CB80", Length = "0x1C8")]
		[Token(Token = "0x6000646")]
		private get { } //Length: 456
	}

	[Token(Token = "0x17000070")]
	public DateTime DateTime
	{
		[Address(RVA = "0x200D950", Offset = "0x200CD50", Length = "0x49")]
		[Token(Token = "0x6000643")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000074")]
	public int Day
	{
		[Address(RVA = "0x200D9A0", Offset = "0x200CDA0", Length = "0xB3")]
		[Token(Token = "0x6000647")]
		 get { } //Length: 179
	}

	[Token(Token = "0x17000075")]
	public int Hour
	{
		[Address(RVA = "0x200DA60", Offset = "0x200CE60", Length = "0xE7")]
		[Token(Token = "0x6000648")]
		 get { } //Length: 231
	}

	[Token(Token = "0x17000072")]
	public DateTime LocalDateTime
	{
		[Address(RVA = "0x200DB50", Offset = "0x200CF50", Length = "0xB0")]
		[Token(Token = "0x6000645")]
		 get { } //Length: 176
	}

	[Token(Token = "0x17000076")]
	public int Millisecond
	{
		[Address(RVA = "0x200DC00", Offset = "0x200D000", Length = "0xE8")]
		[Token(Token = "0x6000649")]
		 get { } //Length: 232
	}

	[Token(Token = "0x17000077")]
	public int Minute
	{
		[Address(RVA = "0x200DCF0", Offset = "0x200D0F0", Length = "0xE8")]
		[Token(Token = "0x600064A")]
		 get { } //Length: 232
	}

	[Token(Token = "0x17000078")]
	public int Month
	{
		[Address(RVA = "0x200DDE0", Offset = "0x200D1E0", Length = "0xB3")]
		[Token(Token = "0x600064B")]
		 get { } //Length: 179
	}

	[Token(Token = "0x1700006F")]
	public static DateTimeOffset Now
	{
		[Address(RVA = "0x200DEA0", Offset = "0x200D2A0", Length = "0x5E")]
		[Token(Token = "0x6000642")]
		 get { } //Length: 94
	}

	[Token(Token = "0x17000079")]
	public TimeSpan Offset
	{
		[Address(RVA = "0x200DF00", Offset = "0x200D300", Length = "0x2E")]
		[Token(Token = "0x600064C")]
		 get { } //Length: 46
	}

	[Token(Token = "0x1700007A")]
	public int Second
	{
		[Address(RVA = "0x200DF30", Offset = "0x200D330", Length = "0xE8")]
		[Token(Token = "0x600064D")]
		 get { } //Length: 232
	}

	[Token(Token = "0x1700007B")]
	public long Ticks
	{
		[Address(RVA = "0x200E020", Offset = "0x200D420", Length = "0xAC")]
		[Token(Token = "0x600064E")]
		 get { } //Length: 172
	}

	[Token(Token = "0x1700007C")]
	public TimeSpan TimeOfDay
	{
		[Address(RVA = "0x200E0D0", Offset = "0x200D4D0", Length = "0xBE")]
		[Token(Token = "0x600064F")]
		 get { } //Length: 190
	}

	[Token(Token = "0x17000071")]
	public DateTime UtcDateTime
	{
		[Address(RVA = "0x200E190", Offset = "0x200D590", Length = "0xA2")]
		[Token(Token = "0x6000644")]
		 get { } //Length: 162
	}

	[Token(Token = "0x1700007D")]
	public int Year
	{
		[Address(RVA = "0x200E240", Offset = "0x200D640", Length = "0xB0")]
		[Token(Token = "0x6000650")]
		 get { } //Length: 176
	}

	[Address(RVA = "0x200CCF0", Offset = "0x200C0F0", Length = "0x116")]
	[Token(Token = "0x600066B")]
	private static DateTimeOffset() { }

	[Address(RVA = "0x200CE10", Offset = "0x200C210", Length = "0x18B")]
	[Token(Token = "0x6000658")]
	private DateTimeOffset(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x200D460", Offset = "0x200C860", Length = "0xEB")]
	[Token(Token = "0x6000641")]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) { }

	[Address(RVA = "0x200D6A0", Offset = "0x200CAA0", Length = "0xDE")]
	[Token(Token = "0x6000640")]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) { }

	[Address(RVA = "0x200D260", Offset = "0x200C660", Length = "0x102")]
	[Token(Token = "0x600063C")]
	public DateTimeOffset(long ticks, TimeSpan offset) { }

	[Address(RVA = "0x200CFA0", Offset = "0x200C3A0", Length = "0x2B6")]
	[Token(Token = "0x600063E")]
	public DateTimeOffset(DateTime dateTime, TimeSpan offset) { }

	[Address(RVA = "0x200D550", Offset = "0x200C950", Length = "0x141")]
	[Token(Token = "0x600063D")]
	public DateTimeOffset(DateTime dateTime) { }

	[Address(RVA = "0x200D370", Offset = "0x200C770", Length = "0xE5")]
	[Token(Token = "0x600063F")]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) { }

	[Address(RVA = "0x200B000", Offset = "0x200A400", Length = "0x94")]
	[Token(Token = "0x6000651")]
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	[Address(RVA = "0x200AEB0", Offset = "0x200A2B0", Length = "0x143")]
	[Token(Token = "0x6000653")]
	public override int CompareTo(DateTimeOffset other) { }

	[Address(RVA = "0x200B240", Offset = "0x200A640", Length = "0xCB")]
	[Token(Token = "0x6000655")]
	public override bool Equals(DateTimeOffset other) { }

	[Address(RVA = "0x200B0A0", Offset = "0x200A4A0", Length = "0x19E")]
	[Token(Token = "0x6000654")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x200D780", Offset = "0x200CB80", Length = "0x1C8")]
	[Token(Token = "0x6000646")]
	private DateTime get_ClockDateTime() { }

	[Address(RVA = "0x200D950", Offset = "0x200CD50", Length = "0x49")]
	[Token(Token = "0x6000643")]
	public DateTime get_DateTime() { }

	[Address(RVA = "0x200D9A0", Offset = "0x200CDA0", Length = "0xB3")]
	[Token(Token = "0x6000647")]
	public int get_Day() { }

	[Address(RVA = "0x200DA60", Offset = "0x200CE60", Length = "0xE7")]
	[Token(Token = "0x6000648")]
	public int get_Hour() { }

	[Address(RVA = "0x200DB50", Offset = "0x200CF50", Length = "0xB0")]
	[Token(Token = "0x6000645")]
	public DateTime get_LocalDateTime() { }

	[Address(RVA = "0x200DC00", Offset = "0x200D000", Length = "0xE8")]
	[Token(Token = "0x6000649")]
	public int get_Millisecond() { }

	[Address(RVA = "0x200DCF0", Offset = "0x200D0F0", Length = "0xE8")]
	[Token(Token = "0x600064A")]
	public int get_Minute() { }

	[Address(RVA = "0x200DDE0", Offset = "0x200D1E0", Length = "0xB3")]
	[Token(Token = "0x600064B")]
	public int get_Month() { }

	[Address(RVA = "0x200DEA0", Offset = "0x200D2A0", Length = "0x5E")]
	[Token(Token = "0x6000642")]
	public static DateTimeOffset get_Now() { }

	[Address(RVA = "0x200DF00", Offset = "0x200D300", Length = "0x2E")]
	[Token(Token = "0x600064C")]
	public TimeSpan get_Offset() { }

	[Address(RVA = "0x200DF30", Offset = "0x200D330", Length = "0xE8")]
	[Token(Token = "0x600064D")]
	public int get_Second() { }

	[Address(RVA = "0x200E020", Offset = "0x200D420", Length = "0xAC")]
	[Token(Token = "0x600064E")]
	public long get_Ticks() { }

	[Address(RVA = "0x200E0D0", Offset = "0x200D4D0", Length = "0xBE")]
	[Token(Token = "0x600064F")]
	public TimeSpan get_TimeOfDay() { }

	[Address(RVA = "0x200E190", Offset = "0x200D590", Length = "0xA2")]
	[Token(Token = "0x6000644")]
	public DateTime get_UtcDateTime() { }

	[Address(RVA = "0x200E240", Offset = "0x200D640", Length = "0xB0")]
	[Token(Token = "0x6000650")]
	public int get_Year() { }

	[Address(RVA = "0x200B310", Offset = "0x200A710", Length = "0xB5")]
	[Token(Token = "0x6000659")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x200E2F0", Offset = "0x200D6F0", Length = "0xCB")]
	[Token(Token = "0x6000669")]
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	[Address(RVA = "0x200E3C0", Offset = "0x200D7C0", Length = "0x20")]
	[Token(Token = "0x6000667")]
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	[Address(RVA = "0x200E3E0", Offset = "0x200D7E0", Length = "0xCB")]
	[Token(Token = "0x600066A")]
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	[Address(RVA = "0x200E4B0", Offset = "0x200D8B0", Length = "0xCB")]
	[Token(Token = "0x6000668")]
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	[Address(RVA = "0x200BA60", Offset = "0x200AE60", Length = "0x8F")]
	[Token(Token = "0x600065A")]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	[Address(RVA = "0x200B7B0", Offset = "0x200ABB0", Length = "0x2A9")]
	[Token(Token = "0x600065B")]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	[Address(RVA = "0x200B3D0", Offset = "0x200A7D0", Length = "0x3DA")]
	[Token(Token = "0x600065C")]
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	[Address(RVA = "0x200BAF0", Offset = "0x200AEF0", Length = "0x163")]
	[Token(Token = "0x6000652")]
	private override int System.IComparable.CompareTo(object obj) { }

	[Address(RVA = "0x200BC60", Offset = "0x200B060", Length = "0x116")]
	[Token(Token = "0x6000656")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x200BD80", Offset = "0x200B180", Length = "0xBB")]
	[Token(Token = "0x6000657")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x200BE40", Offset = "0x200B240", Length = "0xD3")]
	[Token(Token = "0x600065F")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x200BF20", Offset = "0x200B320", Length = "0xB8")]
	[Token(Token = "0x600065D")]
	public virtual string ToString() { }

	[Address(RVA = "0x200BFE0", Offset = "0x200B3E0", Length = "0xC5")]
	[Token(Token = "0x600065E")]
	public string ToString(IFormatProvider formatProvider) { }

	[Address(RVA = "0x200C0B0", Offset = "0x200B4B0", Length = "0x6D")]
	[Token(Token = "0x6000661")]
	public DateTimeOffset ToUniversalTime() { }

	[Address(RVA = "0x200C120", Offset = "0x200B520", Length = "0x107")]
	[Token(Token = "0x6000660")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

	[Address(RVA = "0x200C610", Offset = "0x200BA10", Length = "0x2F8")]
	[Token(Token = "0x6000662")]
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	[Address(RVA = "0x200C230", Offset = "0x200B630", Length = "0x3DF")]
	[Token(Token = "0x6000663")]
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	[Address(RVA = "0x200C910", Offset = "0x200BD10", Length = "0x138")]
	[Token(Token = "0x6000665")]
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	[Address(RVA = "0x200CA50", Offset = "0x200BE50", Length = "0x179")]
	[Token(Token = "0x6000664")]
	private static short ValidateOffset(TimeSpan offset) { }

	[Address(RVA = "0x200CBD0", Offset = "0x200BFD0", Length = "0x11D")]
	[Token(Token = "0x6000666")]
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

}

