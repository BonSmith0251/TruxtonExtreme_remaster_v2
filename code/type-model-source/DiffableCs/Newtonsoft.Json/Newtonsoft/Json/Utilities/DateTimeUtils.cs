namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000A6")]
internal static class DateTimeUtils
{
	[Token(Token = "0x40003FC")]
	internal static readonly long InitialJavaScriptDateTicks; //Field offset: 0x0
	[Token(Token = "0x40003FD")]
	private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK"; //Field offset: 0x0
	[Token(Token = "0x40003FE")]
	private const int DaysPer100Years = 36524; //Field offset: 0x0
	[Token(Token = "0x40003FF")]
	private const int DaysPer400Years = 146097; //Field offset: 0x0
	[Token(Token = "0x4000400")]
	private const int DaysPer4Years = 1461; //Field offset: 0x0
	[Token(Token = "0x4000401")]
	private const int DaysPerYear = 365; //Field offset: 0x0
	[Token(Token = "0x4000402")]
	private const long TicksPerDay = 864000000000; //Field offset: 0x0
	[Token(Token = "0x4000403")]
	private static readonly Int32[] DaysToMonth365; //Field offset: 0x8
	[Token(Token = "0x4000404")]
	private static readonly Int32[] DaysToMonth366; //Field offset: 0x10

	[Address(RVA = "0x2123B40", Offset = "0x2122F40", Length = "0x10A")]
	[Token(Token = "0x6000556")]
	private static DateTimeUtils() { }

	[Address(RVA = "0x2120360", Offset = "0x211F760", Length = "0x1EE")]
	[Token(Token = "0x6000560")]
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	[Address(RVA = "0x2120310", Offset = "0x211F710", Length = "0x4C")]
	[Token(Token = "0x600055F")]
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	[Address(RVA = "0x2120250", Offset = "0x211F650", Length = "0xBD")]
	[Token(Token = "0x600055E")]
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	[Address(RVA = "0x2120550", Offset = "0x211F950", Length = "0x7F")]
	[Token(Token = "0x6000562")]
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	[Address(RVA = "0x21205D0", Offset = "0x211F9D0", Length = "0xA0")]
	[Token(Token = "0x6000573")]
	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	[Address(RVA = "0x2120680", Offset = "0x211FA80", Length = "0x148")]
	[Token(Token = "0x6000565")]
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	[Address(RVA = "0x21207D0", Offset = "0x211FBD0", Length = "0x2A7")]
	[Token(Token = "0x6000559")]
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	[Address(RVA = "0x2120A80", Offset = "0x211FE80", Length = "0x1EB")]
	[Token(Token = "0x6000576")]
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

	[Address(RVA = "0x2120C70", Offset = "0x2120070", Length = "0x5E")]
	[Extension]
	[Token(Token = "0x6000557")]
	public static TimeSpan GetUtcOffset(DateTime d) { }

	[Address(RVA = "0x2120CD0", Offset = "0x21200D0", Length = "0xCC")]
	[Token(Token = "0x600055A")]
	private static DateTime SwitchToLocalTime(DateTime value) { }

	[Address(RVA = "0x2120DA0", Offset = "0x21201A0", Length = "0xCE")]
	[Token(Token = "0x600055B")]
	private static DateTime SwitchToUtcTime(DateTime value) { }

	[Address(RVA = "0x2120E70", Offset = "0x2120270", Length = "0xA9")]
	[Token(Token = "0x6000558")]
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	[Address(RVA = "0x2121090", Offset = "0x2120490", Length = "0x108")]
	[Token(Token = "0x600055C")]
	private static long ToUniversalTicks(DateTime dateTime) { }

	[Address(RVA = "0x2120F20", Offset = "0x2120320", Length = "0x16F")]
	[Token(Token = "0x600055D")]
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	[Address(RVA = "0x21224B0", Offset = "0x21218B0", Length = "0x2C1")]
	[Token(Token = "0x6000567")]
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	[Address(RVA = "0x2122280", Offset = "0x2121680", Length = "0x222")]
	[Token(Token = "0x6000566")]
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	[Address(RVA = "0x21211A0", Offset = "0x21205A0", Length = "0xE4")]
	[Token(Token = "0x600056C")]
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	[Address(RVA = "0x2121290", Offset = "0x2120690", Length = "0x4C6")]
	[Token(Token = "0x6000563")]
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	[Address(RVA = "0x2121760", Offset = "0x2120B60", Length = "0x165")]
	[Token(Token = "0x600056B")]
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	[Address(RVA = "0x2121D90", Offset = "0x2121190", Length = "0x207")]
	[Token(Token = "0x6000568")]
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	[Address(RVA = "0x2121FA0", Offset = "0x21213A0", Length = "0x2D5")]
	[Token(Token = "0x6000569")]
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	[Address(RVA = "0x21218D0", Offset = "0x2120CD0", Length = "0xA8")]
	[Token(Token = "0x600056E")]
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	[Address(RVA = "0x2121980", Offset = "0x2120D80", Length = "0x289")]
	[Token(Token = "0x6000564")]
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	[Address(RVA = "0x2121C10", Offset = "0x2121010", Length = "0x17B")]
	[Token(Token = "0x600056D")]
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	[Address(RVA = "0x2122780", Offset = "0x2121B80", Length = "0x185")]
	[Token(Token = "0x600056A")]
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	[Address(RVA = "0x2122910", Offset = "0x2121D10", Length = "0x24D")]
	[Token(Token = "0x600056F")]
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	[Address(RVA = "0x2122B60", Offset = "0x2121F60", Length = "0x6F")]
	[Token(Token = "0x6000561")]
	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	[Address(RVA = "0x2122DC0", Offset = "0x21221C0", Length = "0x250")]
	[Token(Token = "0x6000574")]
	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	[Address(RVA = "0x2122BD0", Offset = "0x2121FD0", Length = "0x1EB")]
	[Token(Token = "0x6000575")]
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	[Address(RVA = "0x2123020", Offset = "0x2122420", Length = "0x1A2")]
	[Token(Token = "0x6000570")]
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	[Address(RVA = "0x21231D0", Offset = "0x21225D0", Length = "0x3F6")]
	[Token(Token = "0x6000571")]
	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	[Address(RVA = "0x21235D0", Offset = "0x21229D0", Length = "0x56C")]
	[Token(Token = "0x6000572")]
	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

}

