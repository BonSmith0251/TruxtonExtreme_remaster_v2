namespace System.Xml;

[Token(Token = "0x2000010")]
internal abstract class BinXmlDateTime
{
	[Token(Token = "0x400006A")]
	internal static Int32[] KatmaiTimeScaleMultiplicator; //Field offset: 0x0
	[Token(Token = "0x400006B")]
	private static readonly double SQLTicksPerMillisecond; //Field offset: 0x8
	[Token(Token = "0x400006C")]
	public static readonly int SQLTicksPerSecond; //Field offset: 0x10
	[Token(Token = "0x400006D")]
	public static readonly int SQLTicksPerMinute; //Field offset: 0x14
	[Token(Token = "0x400006E")]
	public static readonly int SQLTicksPerHour; //Field offset: 0x18
	[Token(Token = "0x400006F")]
	private static readonly int SQLTicksPerDay; //Field offset: 0x1C

	[Address(RVA = "0x23F1C00", Offset = "0x23F1000", Length = "0x102")]
	[Token(Token = "0x6000047")]
	private static BinXmlDateTime() { }

	[Address(RVA = "0x23EEFF0", Offset = "0x23EE3F0", Length = "0x1AE")]
	[Token(Token = "0x600002D")]
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	[Address(RVA = "0x23EEDC0", Offset = "0x23EE1C0", Length = "0x229")]
	[Token(Token = "0x600002C")]
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	[Address(RVA = "0x23EF1A0", Offset = "0x23EE5A0", Length = "0x145")]
	[Token(Token = "0x600002E")]
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	[Address(RVA = "0x23EF430", Offset = "0x23EE830", Length = "0x121")]
	[Token(Token = "0x6000045")]
	private static int GetFractions(DateTime dt) { }

	[Address(RVA = "0x23EF2F0", Offset = "0x23EE6F0", Length = "0x13E")]
	[Token(Token = "0x6000046")]
	private static int GetFractions(DateTimeOffset dt) { }

	[Address(RVA = "0x23EF560", Offset = "0x23EE960", Length = "0x67")]
	[Token(Token = "0x6000042")]
	private static long GetKatmaiDateTicks(Byte[] data, ref int pos) { }

	[Address(RVA = "0x23EF5D0", Offset = "0x23EE9D0", Length = "0x246")]
	[Token(Token = "0x6000043")]
	private static long GetKatmaiTimeTicks(Byte[] data, ref int pos) { }

	[Address(RVA = "0x23EF820", Offset = "0x23EEC20", Length = "0x49")]
	[Token(Token = "0x6000044")]
	private static long GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	[Address(RVA = "0x23EF870", Offset = "0x23EEC70", Length = "0xDC")]
	[Token(Token = "0x6000033")]
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	[Address(RVA = "0x23EF950", Offset = "0x23EED50", Length = "0x10D")]
	[Token(Token = "0x6000032")]
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	[Address(RVA = "0x23EFA60", Offset = "0x23EEE60", Length = "0x6C")]
	[Token(Token = "0x6000035")]
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	[Address(RVA = "0x23EFAD0", Offset = "0x23EEED0", Length = "0x118")]
	[Token(Token = "0x6000034")]
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	[Address(RVA = "0x20066A0", Offset = "0x2005AA0", Length = "0x72")]
	[Token(Token = "0x6000024")]
	private static void Write2Dig(StringBuilder sb, int val) { }

	[Address(RVA = "0x23EFBF0", Offset = "0x23EEFF0", Length = "0xCF")]
	[Token(Token = "0x6000026")]
	private static void Write3Dec(StringBuilder sb, int val) { }

	[Address(RVA = "0x23EFCC0", Offset = "0x23EF0C0", Length = "0x148")]
	[Token(Token = "0x6000025")]
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	[Address(RVA = "0x23EFE10", Offset = "0x23EF210", Length = "0x13D")]
	[Token(Token = "0x6000027")]
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	[Address(RVA = "0x23F0440", Offset = "0x23EF840", Length = "0x242")]
	[Token(Token = "0x6000028")]
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	[Address(RVA = "0x23EFF50", Offset = "0x23EF350", Length = "0x280")]
	[Token(Token = "0x6000029")]
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	[Address(RVA = "0x23F01E0", Offset = "0x23EF5E0", Length = "0x156")]
	[Token(Token = "0x600002B")]
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	[Address(RVA = "0x23F0340", Offset = "0x23EF740", Length = "0x100")]
	[Token(Token = "0x600002A")]
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	[Address(RVA = "0x23F0690", Offset = "0x23EFA90", Length = "0x312")]
	[Token(Token = "0x600002F")]
	public static string XsdDateTimeToString(long val) { }

	[Address(RVA = "0x23F09B0", Offset = "0x23EFDB0", Length = "0x26E")]
	[Token(Token = "0x6000030")]
	public static string XsdDateToString(long val) { }

	[Address(RVA = "0x23F0C20", Offset = "0x23F0020", Length = "0x75")]
	[Token(Token = "0x6000039")]
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	[Address(RVA = "0x23F0CA0", Offset = "0x23F00A0", Length = "0x170")]
	[Token(Token = "0x600003F")]
	public static string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	[Address(RVA = "0x23F0E20", Offset = "0x23F0220", Length = "0x11F")]
	[Token(Token = "0x600003A")]
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	[Address(RVA = "0x23F0F40", Offset = "0x23F0340", Length = "0x1BD")]
	[Token(Token = "0x6000040")]
	public static string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	[Address(RVA = "0x23F1100", Offset = "0x23F0500", Length = "0xCC")]
	[Token(Token = "0x6000037")]
	public static DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	[Address(RVA = "0x23F11D0", Offset = "0x23F05D0", Length = "0x190")]
	[Token(Token = "0x600003D")]
	public static string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	[Address(RVA = "0x23F1370", Offset = "0x23F0770", Length = "0xBA")]
	[Token(Token = "0x6000036")]
	public static DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	[Address(RVA = "0x23F1430", Offset = "0x23F0830", Length = "0x1C1")]
	[Token(Token = "0x600003C")]
	public static string XsdKatmaiDateToString(Byte[] data, int offset) { }

	[Address(RVA = "0x23F1600", Offset = "0x23F0A00", Length = "0x75")]
	[Token(Token = "0x600003B")]
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	[Address(RVA = "0x23F1680", Offset = "0x23F0A80", Length = "0x199")]
	[Token(Token = "0x6000041")]
	public static string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	[Address(RVA = "0x23F1820", Offset = "0x23F0C20", Length = "0x57")]
	[Token(Token = "0x6000038")]
	public static DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	[Address(RVA = "0x23F1880", Offset = "0x23F0C80", Length = "0x16C")]
	[Token(Token = "0x600003E")]
	public static string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	[Address(RVA = "0x23F19F0", Offset = "0x23F0DF0", Length = "0x203")]
	[Token(Token = "0x6000031")]
	public static string XsdTimeToString(long val) { }

}

