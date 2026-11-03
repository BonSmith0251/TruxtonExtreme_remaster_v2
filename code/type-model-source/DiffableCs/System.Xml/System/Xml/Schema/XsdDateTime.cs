namespace System.Xml.Schema;

[Token(Token = "0x200026A")]
internal struct XsdDateTime
{
	[Token(Token = "0x200026B")]
	private enum DateTimeTypeCode : int
	{
		DateTime = 0,
		Time = 1,
		Date = 2,
		GYearMonth = 3,
		GYear = 4,
		GMonthDay = 5,
		GDay = 6,
		GMonth = 7,
		XdrDateTime = 8,
	}

	[Token(Token = "0x200026D")]
	private struct Parser
	{
		[Token(Token = "0x4000D9A")]
		private static Int32[] Power10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D8D")]
		public DateTimeTypeCode typeCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000D8E")]
		public int year; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000D8F")]
		public int month; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000D90")]
		public int day; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D91")]
		public int hour; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000D92")]
		public int minute; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D93")]
		public int second; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000D94")]
		public int fraction; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D95")]
		public XsdDateTimeKind kind; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000D96")]
		public int zoneHour; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000D97")]
		public int zoneMinute; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000D98")]
		private string text; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000D99")]
		private int length; //Field offset: 0x38

		[Address(RVA = "0x24D9560", Offset = "0x24D8960", Length = "0x8C")]
		[Token(Token = "0x6001942")]
		private static Parser() { }

		[Address(RVA = "0x24D8500", Offset = "0x24D7900", Length = "0x104A")]
		[Token(Token = "0x6001938")]
		public bool Parse(string text, XsdDateTimeFlags kinds) { }

		[Address(RVA = "0x24D7900", Offset = "0x24D6D00", Length = "0x8A")]
		[Token(Token = "0x600193F")]
		private bool Parse2Dig(int start, ref int num) { }

		[Address(RVA = "0x24D7990", Offset = "0x24D6D90", Length = "0xEE")]
		[Token(Token = "0x600193E")]
		private bool Parse4Dig(int start, ref int num) { }

		[Address(RVA = "0x24D7A80", Offset = "0x24D6E80", Length = "0x39")]
		[Token(Token = "0x6001940")]
		private bool ParseChar(int start, char ch) { }

		[Address(RVA = "0x24D7AC0", Offset = "0x24D6EC0", Length = "0x2B5")]
		[Token(Token = "0x6001939")]
		private bool ParseDate(int start) { }

		[Address(RVA = "0x24D7E80", Offset = "0x24D7280", Length = "0x3DD")]
		[Token(Token = "0x600193C")]
		private bool ParseTime(ref int start) { }

		[Address(RVA = "0x24D7D80", Offset = "0x24D7180", Length = "0x6E")]
		[Token(Token = "0x600193B")]
		private bool ParseTimeAndWhitespace(int start) { }

		[Address(RVA = "0x24D7DF0", Offset = "0x24D71F0", Length = "0x88")]
		[Token(Token = "0x600193A")]
		private bool ParseTimeAndZoneAndWhitespace(int start) { }

		[Address(RVA = "0x24D8260", Offset = "0x24D7660", Length = "0x290")]
		[Token(Token = "0x600193D")]
		private bool ParseZoneAndWhitespace(int start) { }

		[Address(RVA = "0x24D9550", Offset = "0x24D8950", Length = "0x6")]
		[Token(Token = "0x6001941")]
		private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	}

	[Token(Token = "0x200026C")]
	private enum XsdDateTimeKind : int
	{
		Unspecified = 0,
		Zulu = 1,
		LocalWestOfZulu = 2,
		LocalEastOfZulu = 3,
	}

	[Token(Token = "0x4000D67")]
	private static readonly int Lzyyyy; //Field offset: 0x0
	[Token(Token = "0x4000D68")]
	private static readonly int Lzyyyy_; //Field offset: 0x4
	[Token(Token = "0x4000D69")]
	private static readonly int Lzyyyy_MM; //Field offset: 0x8
	[Token(Token = "0x4000D6A")]
	private static readonly int Lzyyyy_MM_; //Field offset: 0xC
	[Token(Token = "0x4000D6B")]
	private static readonly int Lzyyyy_MM_dd; //Field offset: 0x10
	[Token(Token = "0x4000D6C")]
	private static readonly int Lzyyyy_MM_ddT; //Field offset: 0x14
	[Token(Token = "0x4000D6D")]
	private static readonly int LzHH; //Field offset: 0x18
	[Token(Token = "0x4000D6E")]
	private static readonly int LzHH_; //Field offset: 0x1C
	[Token(Token = "0x4000D6F")]
	private static readonly int LzHH_mm; //Field offset: 0x20
	[Token(Token = "0x4000D70")]
	private static readonly int LzHH_mm_; //Field offset: 0x24
	[Token(Token = "0x4000D71")]
	private static readonly int LzHH_mm_ss; //Field offset: 0x28
	[Token(Token = "0x4000D72")]
	private static readonly int Lz_; //Field offset: 0x2C
	[Token(Token = "0x4000D73")]
	private static readonly int Lz_zz; //Field offset: 0x30
	[Token(Token = "0x4000D74")]
	private static readonly int Lz_zz_; //Field offset: 0x34
	[Token(Token = "0x4000D75")]
	private static readonly int Lz_zz_zz; //Field offset: 0x38
	[Token(Token = "0x4000D76")]
	private static readonly int Lz__; //Field offset: 0x3C
	[Token(Token = "0x4000D77")]
	private static readonly int Lz__mm; //Field offset: 0x40
	[Token(Token = "0x4000D78")]
	private static readonly int Lz__mm_; //Field offset: 0x44
	[Token(Token = "0x4000D79")]
	private static readonly int Lz__mm__; //Field offset: 0x48
	[Token(Token = "0x4000D7A")]
	private static readonly int Lz__mm_dd; //Field offset: 0x4C
	[Token(Token = "0x4000D7B")]
	private static readonly int Lz___; //Field offset: 0x50
	[Token(Token = "0x4000D7C")]
	private static readonly int Lz___dd; //Field offset: 0x54
	[Token(Token = "0x4000D7D")]
	private static readonly XmlTypeCode[] typeCodes; //Field offset: 0x58
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D65")]
	private DateTime dt; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D66")]
	private uint extra; //Field offset: 0x8

	[Token(Token = "0x17000681")]
	public int Day
	{
		[Address(RVA = "0x24E16D0", Offset = "0x24E0AD0", Length = "0x49")]
		[Token(Token = "0x6001928")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000685")]
	public int Fraction
	{
		[Address(RVA = "0x24E1720", Offset = "0x24E0B20", Length = "0x117")]
		[Token(Token = "0x600192C")]
		 get { } //Length: 279
	}

	[Token(Token = "0x17000682")]
	public int Hour
	{
		[Address(RVA = "0x24E1840", Offset = "0x24E0C40", Length = "0x49")]
		[Token(Token = "0x6001929")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700067E")]
	private XsdDateTimeKind InternalKind
	{
		[Address(RVA = "0x1FA80D0", Offset = "0x1FA74D0", Length = "0x5")]
		[Token(Token = "0x6001925")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700067D")]
	private DateTimeTypeCode InternalTypeCode
	{
		[Address(RVA = "0x24E1890", Offset = "0x24E0C90", Length = "0x5")]
		[Token(Token = "0x6001924")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000683")]
	public int Minute
	{
		[Address(RVA = "0x24E18A0", Offset = "0x24E0CA0", Length = "0x49")]
		[Token(Token = "0x600192A")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000680")]
	public int Month
	{
		[Address(RVA = "0x24E18F0", Offset = "0x24E0CF0", Length = "0x49")]
		[Token(Token = "0x6001927")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000684")]
	public int Second
	{
		[Address(RVA = "0x24E1940", Offset = "0x24E0D40", Length = "0x49")]
		[Token(Token = "0x600192B")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700067F")]
	public int Year
	{
		[Address(RVA = "0x24E1990", Offset = "0x24E0D90", Length = "0x49")]
		[Token(Token = "0x6001926")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000686")]
	public int ZoneHour
	{
		[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
		[Token(Token = "0x600192D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000687")]
	public int ZoneMinute
	{
		[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
		[Token(Token = "0x600192E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x24E0BA0", Offset = "0x24DFFA0", Length = "0x4BC")]
	[Token(Token = "0x6001937")]
	private static XsdDateTime() { }

	[Address(RVA = "0x24E1060", Offset = "0x24E0460", Length = "0x18E")]
	[Token(Token = "0x6001923")]
	public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	[Address(RVA = "0x24E1660", Offset = "0x24E0A60", Length = "0x6A")]
	[Token(Token = "0x6001922")]
	public XsdDateTime(DateTimeOffset dateTimeOffset) { }

	[Address(RVA = "0x24E14B0", Offset = "0x24E08B0", Length = "0x1A6")]
	[Token(Token = "0x6001921")]
	public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds) { }

	[Address(RVA = "0x24E11F0", Offset = "0x24E05F0", Length = "0x223")]
	[Token(Token = "0x600191D")]
	public XsdDateTime(string text, XsdDateTimeFlags kinds) { }

	[Address(RVA = "0x24E1420", Offset = "0x24E0820", Length = "0x85")]
	[Token(Token = "0x600191E")]
	private XsdDateTime(Parser parser) { }

	[Address(RVA = "0x24E16D0", Offset = "0x24E0AD0", Length = "0x49")]
	[Token(Token = "0x6001928")]
	public int get_Day() { }

	[Address(RVA = "0x24E1720", Offset = "0x24E0B20", Length = "0x117")]
	[Token(Token = "0x600192C")]
	public int get_Fraction() { }

	[Address(RVA = "0x24E1840", Offset = "0x24E0C40", Length = "0x49")]
	[Token(Token = "0x6001929")]
	public int get_Hour() { }

	[Address(RVA = "0x1FA80D0", Offset = "0x1FA74D0", Length = "0x5")]
	[Token(Token = "0x6001925")]
	private XsdDateTimeKind get_InternalKind() { }

	[Address(RVA = "0x24E1890", Offset = "0x24E0C90", Length = "0x5")]
	[Token(Token = "0x6001924")]
	private DateTimeTypeCode get_InternalTypeCode() { }

	[Address(RVA = "0x24E18A0", Offset = "0x24E0CA0", Length = "0x49")]
	[Token(Token = "0x600192A")]
	public int get_Minute() { }

	[Address(RVA = "0x24E18F0", Offset = "0x24E0CF0", Length = "0x49")]
	[Token(Token = "0x6001927")]
	public int get_Month() { }

	[Address(RVA = "0x24E1940", Offset = "0x24E0D40", Length = "0x49")]
	[Token(Token = "0x600192B")]
	public int get_Second() { }

	[Address(RVA = "0x24E1990", Offset = "0x24E0D90", Length = "0x49")]
	[Token(Token = "0x6001926")]
	public int get_Year() { }

	[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
	[Token(Token = "0x600192D")]
	public int get_ZoneHour() { }

	[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
	[Token(Token = "0x600192E")]
	public int get_ZoneMinute() { }

	[Address(RVA = "0x24DF7C0", Offset = "0x24DEBC0", Length = "0x122")]
	[Token(Token = "0x600191F")]
	private void InitiateXsdDateTime(Parser parser) { }

	[Address(RVA = "0x24DF8F0", Offset = "0x24DECF0", Length = "0xA1")]
	[Token(Token = "0x6001935")]
	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	[Address(RVA = "0x24E19E0", Offset = "0x24E0DE0", Length = "0x656")]
	[Token(Token = "0x600192F")]
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	[Address(RVA = "0x24E2040", Offset = "0x24E1440", Length = "0x414")]
	[Token(Token = "0x6001930")]
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	[Address(RVA = "0x24DF9A0", Offset = "0x24DEDA0", Length = "0x305")]
	[Token(Token = "0x6001932")]
	private void PrintDate(StringBuilder sb) { }

	[Address(RVA = "0x24DFCB0", Offset = "0x24DF0B0", Length = "0x422")]
	[Token(Token = "0x6001933")]
	private void PrintTime(StringBuilder sb) { }

	[Address(RVA = "0x24E00E0", Offset = "0x24DF4E0", Length = "0x33A")]
	[Token(Token = "0x6001934")]
	private void PrintZone(StringBuilder sb) { }

	[Address(RVA = "0x24E0420", Offset = "0x24DF820", Length = "0x7B")]
	[Token(Token = "0x6001936")]
	private void ShortToCharArray(Char[] text, int start, int value) { }

	[Address(RVA = "0x24E04A0", Offset = "0x24DF8A0", Length = "0x564")]
	[Token(Token = "0x6001931")]
	public virtual string ToString() { }

	[Address(RVA = "0x24E0A30", Offset = "0x24DFE30", Length = "0x164")]
	[Token(Token = "0x6001920")]
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

}

