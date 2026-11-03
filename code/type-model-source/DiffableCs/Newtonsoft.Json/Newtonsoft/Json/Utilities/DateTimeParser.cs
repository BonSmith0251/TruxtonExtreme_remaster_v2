namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000A5")]
internal struct DateTimeParser
{
	[Token(Token = "0x40003FB")]
	private const short MaxFractionDigits = 7; //Field offset: 0x0
	[Token(Token = "0x40003ED")]
	private static readonly Int32[] Power10; //Field offset: 0x0
	[Token(Token = "0x40003EE")]
	private static readonly int Lzyyyy; //Field offset: 0x8
	[Token(Token = "0x40003EF")]
	private static readonly int Lzyyyy_; //Field offset: 0xC
	[Token(Token = "0x40003F0")]
	private static readonly int Lzyyyy_MM; //Field offset: 0x10
	[Token(Token = "0x40003F1")]
	private static readonly int Lzyyyy_MM_; //Field offset: 0x14
	[Token(Token = "0x40003F2")]
	private static readonly int Lzyyyy_MM_dd; //Field offset: 0x18
	[Token(Token = "0x40003F3")]
	private static readonly int Lzyyyy_MM_ddT; //Field offset: 0x1C
	[Token(Token = "0x40003F4")]
	private static readonly int LzHH; //Field offset: 0x20
	[Token(Token = "0x40003F5")]
	private static readonly int LzHH_; //Field offset: 0x24
	[Token(Token = "0x40003F6")]
	private static readonly int LzHH_mm; //Field offset: 0x28
	[Token(Token = "0x40003F7")]
	private static readonly int LzHH_mm_; //Field offset: 0x2C
	[Token(Token = "0x40003F8")]
	private static readonly int LzHH_mm_ss; //Field offset: 0x30
	[Token(Token = "0x40003F9")]
	private static readonly int Lz_; //Field offset: 0x34
	[Token(Token = "0x40003FA")]
	private static readonly int Lz_zz; //Field offset: 0x38
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E1")]
	public int Year; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003E2")]
	public int Month; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003E3")]
	public int Day; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40003E4")]
	public int Hour; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E5")]
	public int Minute; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003E6")]
	public int Second; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003E7")]
	public int Fraction; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40003E8")]
	public int ZoneHour; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003E9")]
	public int ZoneMinute; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003EA")]
	public ParserTimeZone Zone; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003EB")]
	private Char[] _text; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003EC")]
	private int _end; //Field offset: 0x30

	[Address(RVA = "0x211FF50", Offset = "0x211F350", Length = "0x2F6")]
	[Token(Token = "0x600054D")]
	private static DateTimeParser() { }

	[Address(RVA = "0x211FE30", Offset = "0x211F230", Length = "0x118")]
	[Token(Token = "0x600054E")]
	public bool Parse(Char[] text, int startIndex, int length) { }

	[Address(RVA = "0x211F2D0", Offset = "0x211E6D0", Length = "0x75")]
	[Token(Token = "0x6000554")]
	private bool Parse2Digit(int start, out int num) { }

	[Address(RVA = "0x211F350", Offset = "0x211E750", Length = "0xCF")]
	[Token(Token = "0x6000553")]
	private bool Parse4Digit(int start, out int num) { }

	[Address(RVA = "0x211F420", Offset = "0x211E820", Length = "0x3A")]
	[Token(Token = "0x6000555")]
	private bool ParseChar(int start, char ch) { }

	[Address(RVA = "0x211F460", Offset = "0x211E860", Length = "0x2B0")]
	[Token(Token = "0x600054F")]
	private bool ParseDate(int start) { }

	[Address(RVA = "0x211F7A0", Offset = "0x211EBA0", Length = "0x420")]
	[Token(Token = "0x6000551")]
	private bool ParseTime(ref int start) { }

	[Address(RVA = "0x211F720", Offset = "0x211EB20", Length = "0x80")]
	[Token(Token = "0x6000550")]
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	[Address(RVA = "0x211FBD0", Offset = "0x211EFD0", Length = "0x25D")]
	[Token(Token = "0x6000552")]
	private bool ParseZone(int start) { }

}

