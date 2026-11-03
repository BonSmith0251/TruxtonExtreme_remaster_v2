namespace System.Xml;

[Token(Token = "0x20000C7")]
public class XmlConvert
{
	[Token(Token = "0x4000558")]
	private static XmlCharType xmlCharType; //Field offset: 0x0
	[Token(Token = "0x4000559")]
	internal static Char[] crt; //Field offset: 0x8
	[Token(Token = "0x400055A")]
	private static readonly int c_EncodedCharLength; //Field offset: 0x10
	[Token(Token = "0x400055B")]
	private static Regex c_EncodeCharPattern; //Field offset: 0x18
	[Token(Token = "0x400055C")]
	private static Regex c_DecodeCharPattern; //Field offset: 0x20
	[Token(Token = "0x400055D")]
	private static String[] s_allDateTimeFormats; //Field offset: 0x28
	[Token(Token = "0x400055E")]
	internal static readonly Char[] WhitespaceChars; //Field offset: 0x30

	[Token(Token = "0x170002C8")]
	private static String[] AllDateTimeFormats
	{
		[Address(RVA = "0x2558DB0", Offset = "0x25581B0", Length = "0xA9")]
		[Token(Token = "0x6000AD3")]
		private get { } //Length: 169
	}

	[Address(RVA = "0x2558C70", Offset = "0x2558070", Length = "0x131")]
	[Token(Token = "0x6000AF6")]
	private static XmlConvert() { }

	[Address(RVA = "0x2551410", Offset = "0x2550810", Length = "0x517")]
	[Token(Token = "0x6000AD4")]
	private static void CreateAllDateTimeFormats() { }

	[Address(RVA = "0x2551B60", Offset = "0x2550F60", Length = "0xCF")]
	[Token(Token = "0x6000AE7")]
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	[Address(RVA = "0x2551930", Offset = "0x2550D30", Length = "0x147")]
	[Token(Token = "0x6000AE8")]
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	[Address(RVA = "0x2551C30", Offset = "0x2551030", Length = "0x75")]
	[Token(Token = "0x6000AE9")]
	internal static Exception CreateException(string res, String[] args, ExceptionType exceptionType) { }

	[Address(RVA = "0x2551A80", Offset = "0x2550E80", Length = "0xD1")]
	[Token(Token = "0x6000AEA")]
	internal static Exception CreateException(string res, String[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	[Address(RVA = "0x2551CB0", Offset = "0x25510B0", Length = "0xCA")]
	[Token(Token = "0x6000AF3")]
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	[Address(RVA = "0x2551E60", Offset = "0x2551260", Length = "0x130")]
	[Token(Token = "0x6000AF2")]
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	[Address(RVA = "0x2551D80", Offset = "0x2551180", Length = "0xDC")]
	[Token(Token = "0x6000AF1")]
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	[Address(RVA = "0x2552370", Offset = "0x2551770", Length = "0x4C")]
	[Token(Token = "0x6000AEE")]
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	[Address(RVA = "0x2552190", Offset = "0x2551590", Length = "0x1DE")]
	[Token(Token = "0x6000AF0")]
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	[Address(RVA = "0x2551F90", Offset = "0x2551390", Length = "0x1FE")]
	[Token(Token = "0x6000AEF")]
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	[Address(RVA = "0x25523C0", Offset = "0x25517C0", Length = "0xB3")]
	[Token(Token = "0x6000AF5")]
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	[Address(RVA = "0x2552480", Offset = "0x2551880", Length = "0x101")]
	[Token(Token = "0x6000AF4")]
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	[Address(RVA = "0x25526B0", Offset = "0x2551AB0", Length = "0x173")]
	[Token(Token = "0x6000AED")]
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	[Address(RVA = "0x2552630", Offset = "0x2551A30", Length = "0x75")]
	[Token(Token = "0x6000AEC")]
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	[Address(RVA = "0x2552590", Offset = "0x2551990", Length = "0x99")]
	[Token(Token = "0x6000AEB")]
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	[Address(RVA = "0x2552830", Offset = "0x2551C30", Length = "0x87D")]
	[Token(Token = "0x6000A92")]
	public static string DecodeName(string name) { }

	[Address(RVA = "0x1F8CFC0", Offset = "0x1F8C3C0", Length = "0x6")]
	[Token(Token = "0x6000AE5")]
	private static long DoubleToInt64Bits(double value) { }

	[Address(RVA = "0x25530B0", Offset = "0x25524B0", Length = "0x51")]
	[Token(Token = "0x6000A91")]
	public static string EncodeLocalName(string name) { }

	[Address(RVA = "0x2553110", Offset = "0x2552510", Length = "0x4F")]
	[Token(Token = "0x6000A90")]
	public static string EncodeName(string name) { }

	[Address(RVA = "0x2553160", Offset = "0x2552560", Length = "0x86C")]
	[Token(Token = "0x6000A93")]
	private static string EncodeName(string name, bool first, bool local) { }

	[Address(RVA = "0x25539D0", Offset = "0x2552DD0", Length = "0xA3")]
	[Token(Token = "0x6000A95")]
	internal static Byte[] FromBinHexString(string s) { }

	[Address(RVA = "0x2553A80", Offset = "0x2552E80", Length = "0x70")]
	[Token(Token = "0x6000A96")]
	internal static Byte[] FromBinHexString(string s, bool allowOddCount) { }

	[Address(RVA = "0x2553B00", Offset = "0x2552F00", Length = "0x26")]
	[Token(Token = "0x6000A94")]
	private static int FromHex(char digit) { }

	[Address(RVA = "0x2558DB0", Offset = "0x25581B0", Length = "0xA9")]
	[Token(Token = "0x6000AD3")]
	private static String[] get_AllDateTimeFormats() { }

	[Address(RVA = "0x2553B30", Offset = "0x2552F30", Length = "0x6D")]
	[Token(Token = "0x6000AE4")]
	internal static bool IsNegativeZero(double value) { }

	[Address(RVA = "0x2553BA0", Offset = "0x2552FA0", Length = "0x6F")]
	[Token(Token = "0x6000AE3")]
	internal static String[] SplitString(string value) { }

	[Address(RVA = "0x2553C10", Offset = "0x2553010", Length = "0xAC")]
	[Token(Token = "0x6000ADF")]
	internal static bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	[Address(RVA = "0x2553CC0", Offset = "0x25530C0", Length = "0xCC")]
	[Token(Token = "0x6000ADB")]
	private static DateTime SwitchToLocalTime(DateTime value) { }

	[Address(RVA = "0x2553D90", Offset = "0x2553190", Length = "0xCE")]
	[Token(Token = "0x6000ADC")]
	private static DateTime SwitchToUtcTime(DateTime value) { }

	[Address(RVA = "0x2553E60", Offset = "0x2553260", Length = "0x6D")]
	[Token(Token = "0x6000A97")]
	internal static string ToBinHexString(Byte[] inArray) { }

	[Address(RVA = "0x2553ED0", Offset = "0x25532D0", Length = "0x211")]
	[Token(Token = "0x6000AB4")]
	public static bool ToBoolean(string s) { }

	[Address(RVA = "0x25540F0", Offset = "0x25534F0", Length = "0x28")]
	[Token(Token = "0x6000AC4")]
	public static byte ToByte(string s) { }

	[Address(RVA = "0x2554120", Offset = "0x2553520", Length = "0xC8")]
	[Token(Token = "0x6000AB6")]
	public static char ToChar(string s) { }

	[Address(RVA = "0x25546A0", Offset = "0x2553AA0", Length = "0x9E")]
	[Token(Token = "0x6000AD6")]
	public static DateTime ToDateTime(string s, String[] formats) { }

	[Address(RVA = "0x25542D0", Offset = "0x25536D0", Length = "0x25B")]
	[Token(Token = "0x6000AD7")]
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	[Address(RVA = "0x2554530", Offset = "0x2553930", Length = "0x163")]
	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	[Token(Token = "0x6000AD5")]
	public static DateTime ToDateTime(string s) { }

	[Address(RVA = "0x25541F0", Offset = "0x25535F0", Length = "0xDD")]
	[Token(Token = "0x6000AD8")]
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	[Address(RVA = "0x2554740", Offset = "0x2553B40", Length = "0x88")]
	[Token(Token = "0x6000AB8")]
	public static decimal ToDecimal(string s) { }

	[Address(RVA = "0x25547D0", Offset = "0x2553BD0", Length = "0x16D")]
	[Token(Token = "0x6000ACE")]
	public static double ToDouble(string s) { }

	[Address(RVA = "0x2554940", Offset = "0x2553D40", Length = "0x20")]
	[Token(Token = "0x6000AD9")]
	public static Guid ToGuid(string s) { }

	[Address(RVA = "0x2554960", Offset = "0x2553D60", Length = "0x28")]
	[Token(Token = "0x6000ABE")]
	public static short ToInt16(string s) { }

	[Address(RVA = "0x2554990", Offset = "0x2553D90", Length = "0x28")]
	[Token(Token = "0x6000AC0")]
	public static int ToInt32(string s) { }

	[Address(RVA = "0x25549C0", Offset = "0x2553DC0", Length = "0x28")]
	[Token(Token = "0x6000AC2")]
	public static long ToInt64(string s) { }

	[Address(RVA = "0x25549F0", Offset = "0x2553DF0", Length = "0x88")]
	[Token(Token = "0x6000ABA")]
	internal static decimal ToInteger(string s) { }

	[Address(RVA = "0x2554A80", Offset = "0x2553E80", Length = "0x28")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000ABC")]
	public static sbyte ToSByte(string s) { }

	[Address(RVA = "0x2554AB0", Offset = "0x2553EB0", Length = "0x16C")]
	[Token(Token = "0x6000ACC")]
	public static float ToSingle(string s) { }

	[Address(RVA = "0x2554EF0", Offset = "0x25542F0", Length = "0x63")]
	[Token(Token = "0x6000AA4")]
	public static string ToString(decimal value) { }

	[Address(RVA = "0x25552B0", Offset = "0x25546B0", Length = "0x48")]
	[Token(Token = "0x6000AA2")]
	public static string ToString(bool value) { }

	[Address(RVA = "0x2555400", Offset = "0x2554800", Length = "0x26")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000AA5")]
	public static string ToString(sbyte value) { }

	[Address(RVA = "0x2554F60", Offset = "0x2554360", Length = "0x32")]
	[Token(Token = "0x6000AA3")]
	public static string ToString(char value) { }

	[Address(RVA = "0x2555370", Offset = "0x2554770", Length = "0x8C")]
	[Token(Token = "0x6000AB0")]
	public static string ToString(DateTime value, string format) { }

	[Address(RVA = "0x2554D20", Offset = "0x2554120", Length = "0xFC")]
	[Token(Token = "0x6000AAD")]
	public static string ToString(float value) { }

	[Address(RVA = "0x2554C20", Offset = "0x2554020", Length = "0xFA")]
	[Token(Token = "0x6000AAE")]
	public static string ToString(double value) { }

	[Address(RVA = "0x2555300", Offset = "0x2554700", Length = "0x64")]
	[Token(Token = "0x6000AAF")]
	public static string ToString(TimeSpan value) { }

	[Address(RVA = "0x2554E20", Offset = "0x2554220", Length = "0x27")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000AAA")]
	public static string ToString(ushort value) { }

	[Address(RVA = "0x2555070", Offset = "0x2554470", Length = "0x232")]
	[Token(Token = "0x6000AB1")]
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	[Address(RVA = "0x2554EC0", Offset = "0x25542C0", Length = "0x26")]
	[Token(Token = "0x6000AA9")]
	public static string ToString(byte value) { }

	[Address(RVA = "0x2555040", Offset = "0x2554440", Length = "0x27")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000AAC")]
	public static string ToString(ulong value) { }

	[Address(RVA = "0x2554EB0", Offset = "0x25542B0", Length = "0x10")]
	[Token(Token = "0x6000AB3")]
	public static string ToString(Guid value) { }

	[Address(RVA = "0x2554FD0", Offset = "0x25543D0", Length = "0x6E")]
	[Token(Token = "0x6000AB2")]
	public static string ToString(DateTimeOffset value) { }

	[Address(RVA = "0x2554E80", Offset = "0x2554280", Length = "0x26")]
	[Token(Token = "0x6000AA7")]
	public static string ToString(int value) { }

	[Address(RVA = "0x2554E50", Offset = "0x2554250", Length = "0x27")]
	[Token(Token = "0x6000AA6")]
	public static string ToString(short value) { }

	[Address(RVA = "0x2555430", Offset = "0x2554830", Length = "0x27")]
	[Token(Token = "0x6000AA8")]
	public static string ToString(long value) { }

	[Address(RVA = "0x2554FA0", Offset = "0x25543A0", Length = "0x26")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000AAB")]
	public static string ToString(uint value) { }

	[Address(RVA = "0x2555460", Offset = "0x2554860", Length = "0x15C")]
	[Token(Token = "0x6000AD1")]
	public static TimeSpan ToTimeSpan(string s) { }

	[Address(RVA = "0x25555C0", Offset = "0x25549C0", Length = "0x28")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000AC6")]
	public static ushort ToUInt16(string s) { }

	[Address(RVA = "0x25555F0", Offset = "0x25549F0", Length = "0x28")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000AC8")]
	public static uint ToUInt32(string s) { }

	[Address(RVA = "0x2555620", Offset = "0x2554A20", Length = "0x28")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000ACA")]
	public static ulong ToUInt64(string s) { }

	[Address(RVA = "0x2555650", Offset = "0x2554A50", Length = "0x2DA")]
	[Token(Token = "0x6000ADD")]
	internal static Uri ToUri(string s) { }

	[Address(RVA = "0x2555930", Offset = "0x2554D30", Length = "0x1FF")]
	[Token(Token = "0x6000AD0")]
	internal static double ToXPathDouble(object o) { }

	[Address(RVA = "0x2555C10", Offset = "0x2555010", Length = "0x69")]
	[Token(Token = "0x6000AE0")]
	internal static string TrimString(string value) { }

	[Address(RVA = "0x2555B30", Offset = "0x2554F30", Length = "0x69")]
	[Token(Token = "0x6000AE2")]
	internal static string TrimStringEnd(string value) { }

	[Address(RVA = "0x2555BA0", Offset = "0x2554FA0", Length = "0x69")]
	[Token(Token = "0x6000AE1")]
	internal static string TrimStringStart(string value) { }

	[Address(RVA = "0x2555C80", Offset = "0x2555080", Length = "0x289")]
	[Token(Token = "0x6000AB5")]
	internal static Exception TryToBoolean(string s, out bool result) { }

	[Address(RVA = "0x2555F10", Offset = "0x2555310", Length = "0x180")]
	[Token(Token = "0x6000AC5")]
	internal static Exception TryToByte(string s, out byte result) { }

	[Address(RVA = "0x25560A0", Offset = "0x25554A0", Length = "0x180")]
	[Token(Token = "0x6000AB7")]
	internal static Exception TryToChar(string s, out char result) { }

	[Address(RVA = "0x2556230", Offset = "0x2555630", Length = "0x1B3")]
	[Token(Token = "0x6000AB9")]
	internal static Exception TryToDecimal(string s, out decimal result) { }

	[Address(RVA = "0x25563F0", Offset = "0x25557F0", Length = "0x2BB")]
	[Token(Token = "0x6000ACF")]
	internal static Exception TryToDouble(string s, out double result) { }

	[Address(RVA = "0x25566B0", Offset = "0x2555AB0", Length = "0x255")]
	[Token(Token = "0x6000ADA")]
	internal static Exception TryToGuid(string s, out Guid result) { }

	[Address(RVA = "0x2556910", Offset = "0x2555D10", Length = "0x180")]
	[Token(Token = "0x6000ABF")]
	internal static Exception TryToInt16(string s, out short result) { }

	[Address(RVA = "0x2556AA0", Offset = "0x2555EA0", Length = "0x180")]
	[Token(Token = "0x6000AC1")]
	internal static Exception TryToInt32(string s, out int result) { }

	[Address(RVA = "0x2556C30", Offset = "0x2556030", Length = "0x180")]
	[Token(Token = "0x6000AC3")]
	internal static Exception TryToInt64(string s, out long result) { }

	[Address(RVA = "0x2556DC0", Offset = "0x25561C0", Length = "0x1B3")]
	[Token(Token = "0x6000ABB")]
	internal static Exception TryToInteger(string s, out decimal result) { }

	[Address(RVA = "0x2556F80", Offset = "0x2556380", Length = "0x180")]
	[Token(Token = "0x6000ABD")]
	internal static Exception TryToSByte(string s, out sbyte result) { }

	[Address(RVA = "0x2557110", Offset = "0x2556510", Length = "0x2A1")]
	[Token(Token = "0x6000ACD")]
	internal static Exception TryToSingle(string s, out float result) { }

	[Address(RVA = "0x25573C0", Offset = "0x25567C0", Length = "0xAD")]
	[Token(Token = "0x6000AD2")]
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	[Address(RVA = "0x2557470", Offset = "0x2556870", Length = "0x180")]
	[Token(Token = "0x6000AC7")]
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[Address(RVA = "0x2557600", Offset = "0x2556A00", Length = "0x180")]
	[Token(Token = "0x6000AC9")]
	internal static Exception TryToUInt32(string s, out uint result) { }

	[Address(RVA = "0x2557790", Offset = "0x2556B90", Length = "0x180")]
	[Token(Token = "0x6000ACB")]
	internal static Exception TryToUInt64(string s, out ulong result) { }

	[Address(RVA = "0x2557920", Offset = "0x2556D20", Length = "0x2F4")]
	[Token(Token = "0x6000ADE")]
	internal static Exception TryToUri(string s, out Uri result) { }

	[Address(RVA = "0x2557EF0", Offset = "0x25572F0", Length = "0x196")]
	[Token(Token = "0x6000A99")]
	internal static Exception TryVerifyName(string name) { }

	[Address(RVA = "0x2557C20", Offset = "0x2557020", Length = "0xCD")]
	[Token(Token = "0x6000A9D")]
	internal static Exception TryVerifyNCName(string name) { }

	[Address(RVA = "0x2557CF0", Offset = "0x25570F0", Length = "0x1F4")]
	[Token(Token = "0x6000AA0")]
	internal static Exception TryVerifyNMTOKEN(string name) { }

	[Address(RVA = "0x2558090", Offset = "0x2557490", Length = "0xC0")]
	[Token(Token = "0x6000AA1")]
	internal static Exception TryVerifyNormalizedString(string str) { }

	[Address(RVA = "0x2558160", Offset = "0x2557560", Length = "0x11B")]
	[Token(Token = "0x6000A9F")]
	internal static Exception TryVerifyTOKEN(string token) { }

	[Address(RVA = "0x2558280", Offset = "0x2557680", Length = "0x277")]
	[Token(Token = "0x6000AE6")]
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	[Address(RVA = "0x2558810", Offset = "0x2557C10", Length = "0x15F")]
	[Token(Token = "0x6000A98")]
	public static string VerifyName(string name) { }

	[Address(RVA = "0x25586A0", Offset = "0x2557AA0", Length = "0x167")]
	[Token(Token = "0x6000A9C")]
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	[Address(RVA = "0x2558500", Offset = "0x2557900", Length = "0x190")]
	[Token(Token = "0x6000A9B")]
	public static string VerifyNCName(string name) { }

	[Address(RVA = "0x2558970", Offset = "0x2557D70", Length = "0x1C1")]
	[Token(Token = "0x6000A9A")]
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	[Address(RVA = "0x2558B40", Offset = "0x2557F40", Length = "0x122")]
	[Token(Token = "0x6000A9E")]
	public static string VerifyTOKEN(string token) { }

}

