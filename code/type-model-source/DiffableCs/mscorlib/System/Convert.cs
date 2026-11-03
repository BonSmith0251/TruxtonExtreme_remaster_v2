namespace System;

[Extension]
[Token(Token = "0x20000C5")]
public static class Convert
{
	[Token(Token = "0x40002AD")]
	private static readonly SByte[] s_decodingMap; //Field offset: 0x0
	[Token(Token = "0x40002AE")]
	internal static readonly Type[] ConvertTypes; //Field offset: 0x8
	[Token(Token = "0x40002AF")]
	private static readonly Type EnumType; //Field offset: 0x10
	[Token(Token = "0x40002B0")]
	internal static readonly Char[] base64Table; //Field offset: 0x18
	[Token(Token = "0x40002B1")]
	public static readonly object DBNull; //Field offset: 0x20

	[Address(RVA = "0x1F9A9C0", Offset = "0x1F99DC0", Length = "0x935")]
	[Token(Token = "0x60005BF")]
	private static Convert() { }

	[Address(RVA = "0x1F92AA0", Offset = "0x1F91EA0", Length = "0x454")]
	[Token(Token = "0x60004D2")]
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	[Address(RVA = "0x1F92130", Offset = "0x1F91530", Length = "0x91")]
	[Token(Token = "0x60004D4")]
	public static object ChangeType(object value, Type conversionType) { }

	[Address(RVA = "0x1F921D0", Offset = "0x1F915D0", Length = "0x8C1")]
	[Token(Token = "0x60004D5")]
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	[Address(RVA = "0x1F92F40", Offset = "0x1F92340", Length = "0x35B")]
	[Token(Token = "0x60005B6")]
	private static int ConvertToBase64Array(Char* outChars, Byte* inData, int offset, int length, bool insertLineBreaks) { }

	[Address(RVA = "0x1F932A0", Offset = "0x1F926A0", Length = "0x118")]
	[Token(Token = "0x60005BA")]
	private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<Char> chars, Span<Char> tempBuffer, out int consumed, out int charsWritten) { }

	[Address(RVA = "0x1F933C0", Offset = "0x1F927C0", Length = "0x60")]
	[Token(Token = "0x60004CF")]
	private static int Decode(ref char encodedChars, ref sbyte decodingMap) { }

	[Address(RVA = "0x1F93420", Offset = "0x1F92820", Length = "0x9B5")]
	[Token(Token = "0x60004D3")]
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	[Address(RVA = "0x1F94340", Offset = "0x1F93740", Length = "0xBB")]
	[Token(Token = "0x60005BE")]
	private static int FromBase64_ComputeResultLength(Char* inputPtr, int inputLength) { }

	[Address(RVA = "0x1F93DE0", Offset = "0x1F931E0", Length = "0x27F")]
	[Token(Token = "0x60005BC")]
	public static Byte[] FromBase64CharArray(Char[] inArray, int offset, int length) { }

	[Address(RVA = "0x1F94060", Offset = "0x1F93460", Length = "0x21F")]
	[Token(Token = "0x60005BD")]
	private static Byte[] FromBase64CharPtr(Char* inputPtr, int inputLength) { }

	[Address(RVA = "0x1F94280", Offset = "0x1F93680", Length = "0xB3")]
	[Token(Token = "0x60005B8")]
	public static Byte[] FromBase64String(string s) { }

	[Address(RVA = "0x1F94400", Offset = "0x1F93800", Length = "0x67")]
	[Token(Token = "0x60004D1")]
	public static TypeCode GetTypeCode(object value) { }

	[Address(RVA = "0x1F94470", Offset = "0x1F93870", Length = "0x21")]
	[Extension]
	[Token(Token = "0x60005BB")]
	private static bool IsSpace(char c) { }

	[Address(RVA = "0x1F944A0", Offset = "0x1F938A0", Length = "0x4E")]
	[Token(Token = "0x60004D7")]
	private static void ThrowByteOverflowException() { }

	[Address(RVA = "0x1F944F0", Offset = "0x1F938F0", Length = "0x4E")]
	[Token(Token = "0x60004D6")]
	private static void ThrowCharOverflowException() { }

	[Address(RVA = "0x1F94540", Offset = "0x1F93940", Length = "0x4E")]
	[Token(Token = "0x60004D9")]
	private static void ThrowInt16OverflowException() { }

	[Address(RVA = "0x1F94590", Offset = "0x1F93990", Length = "0x4E")]
	[Token(Token = "0x60004DB")]
	private static void ThrowInt32OverflowException() { }

	[Address(RVA = "0x1F945E0", Offset = "0x1F939E0", Length = "0x4E")]
	[Token(Token = "0x60004DD")]
	private static void ThrowInt64OverflowException() { }

	[Address(RVA = "0x1F94630", Offset = "0x1F93A30", Length = "0x4E")]
	[Token(Token = "0x60004D8")]
	private static void ThrowSByteOverflowException() { }

	[Address(RVA = "0x1F94680", Offset = "0x1F93A80", Length = "0x4E")]
	[Token(Token = "0x60004DA")]
	private static void ThrowUInt16OverflowException() { }

	[Address(RVA = "0x1F946D0", Offset = "0x1F93AD0", Length = "0x4E")]
	[Token(Token = "0x60004DC")]
	private static void ThrowUInt32OverflowException() { }

	[Address(RVA = "0x1F94720", Offset = "0x1F93B20", Length = "0x4E")]
	[Token(Token = "0x60004DE")]
	private static void ThrowUInt64OverflowException() { }

	[Address(RVA = "0x1F95190", Offset = "0x1F94590", Length = "0xEB")]
	[Token(Token = "0x60005B7")]
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	[Address(RVA = "0x1F94800", Offset = "0x1F93C00", Length = "0x431")]
	[Token(Token = "0x60005B5")]
	public static int ToBase64CharArray(Byte[] inArray, int offsetIn, int length, Char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	[Address(RVA = "0x1F94770", Offset = "0x1F93B70", Length = "0x88")]
	[Token(Token = "0x60005B4")]
	public static int ToBase64CharArray(Byte[] inArray, int offsetIn, int length, Char[] outArray, int offsetOut) { }

	[Address(RVA = "0x1F94E80", Offset = "0x1F94280", Length = "0x1B0")]
	[Token(Token = "0x60005B3")]
	public static string ToBase64String(ReadOnlySpan<Byte> bytes, Base64FormattingOptions options = 0) { }

	[Address(RVA = "0x1F94C40", Offset = "0x1F94040", Length = "0x238")]
	[Token(Token = "0x60005B2")]
	public static string ToBase64String(Byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	[Address(RVA = "0x1F95110", Offset = "0x1F94510", Length = "0x71")]
	[Token(Token = "0x60005B1")]
	public static string ToBase64String(Byte[] inArray, int offset, int length) { }

	[Address(RVA = "0x1F95040", Offset = "0x1F94440", Length = "0xCB")]
	[Token(Token = "0x60005B0")]
	public static string ToBase64String(Byte[] inArray) { }

	[Address(RVA = "0x1F95480", Offset = "0x1F94880", Length = "0x73")]
	[Token(Token = "0x60004ED")]
	public static bool ToBoolean(decimal value) { }

	[Address(RVA = "0x1F95460", Offset = "0x1F94860", Length = "0x11")]
	[Token(Token = "0x60004EC")]
	public static bool ToBoolean(double value) { }

	[Address(RVA = "0x1F95400", Offset = "0x1F94800", Length = "0x3A")]
	[Token(Token = "0x60004EA")]
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F95280", Offset = "0x1F94680", Length = "0x7")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004E8")]
	public static bool ToBoolean(ulong value) { }

	[Address(RVA = "0x1F95280", Offset = "0x1F94680", Length = "0x7")]
	[Token(Token = "0x60004E7")]
	public static bool ToBoolean(long value) { }

	[Address(RVA = "0x1F95350", Offset = "0x1F94750", Length = "0x6")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004E6")]
	public static bool ToBoolean(uint value) { }

	[Address(RVA = "0x1F95350", Offset = "0x1F94750", Length = "0x6")]
	[Token(Token = "0x60004E5")]
	public static bool ToBoolean(int value) { }

	[Address(RVA = "0x1F95450", Offset = "0x1F94850", Length = "0x7")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004E4")]
	public static bool ToBoolean(ushort value) { }

	[Address(RVA = "0x1F95450", Offset = "0x1F94850", Length = "0x7")]
	[Token(Token = "0x60004E3")]
	public static bool ToBoolean(short value) { }

	[Address(RVA = "0x1F95290", Offset = "0x1F94690", Length = "0x6")]
	[Token(Token = "0x60004E2")]
	public static bool ToBoolean(byte value) { }

	[Address(RVA = "0x1F95290", Offset = "0x1F94690", Length = "0x6")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004E1")]
	public static bool ToBoolean(sbyte value) { }

	[Address(RVA = "0x1F952A0", Offset = "0x1F946A0", Length = "0xAB")]
	[Token(Token = "0x60004E0")]
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F95360", Offset = "0x1F94760", Length = "0x9A")]
	[Token(Token = "0x60004DF")]
	public static bool ToBoolean(object value) { }

	[Address(RVA = "0x1F95440", Offset = "0x1F94840", Length = "0x10")]
	[Token(Token = "0x60004EB")]
	public static bool ToBoolean(float value) { }

	[Address(RVA = "0x1F95400", Offset = "0x1F94800", Length = "0x3A")]
	[Token(Token = "0x60004E9")]
	public static bool ToBoolean(string value) { }

	[Address(RVA = "0x1F95890", Offset = "0x1F94C90", Length = "0x4B")]
	[Token(Token = "0x600050C")]
	public static byte ToByte(char value) { }

	[Address(RVA = "0x1F95C70", Offset = "0x1F95070", Length = "0xC9")]
	[Token(Token = "0x6000517")]
	public static byte ToByte(string value) { }

	[Address(RVA = "0x1F95B80", Offset = "0x1F94F80", Length = "0x4B")]
	[CLSCompliant(False)]
	[Token(Token = "0x600050F")]
	public static byte ToByte(ushort value) { }

	[Address(RVA = "0x1F958E0", Offset = "0x1F94CE0", Length = "0x48")]
	[Token(Token = "0x6000510")]
	public static byte ToByte(int value) { }

	[Address(RVA = "0x1F959D0", Offset = "0x1F94DD0", Length = "0x48")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000511")]
	public static byte ToByte(uint value) { }

	[Address(RVA = "0x1F95840", Offset = "0x1F94C40", Length = "0x4A")]
	[Token(Token = "0x6000512")]
	public static byte ToByte(long value) { }

	[Address(RVA = "0x1F95500", Offset = "0x1F94900", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000513")]
	public static byte ToByte(ulong value) { }

	[Address(RVA = "0x1F955A0", Offset = "0x1F949A0", Length = "0xC5")]
	[Token(Token = "0x6000514")]
	public static byte ToByte(float value) { }

	[Address(RVA = "0x1F957A0", Offset = "0x1F94BA0", Length = "0x90")]
	[Token(Token = "0x6000515")]
	public static byte ToByte(double value) { }

	[Address(RVA = "0x1F95720", Offset = "0x1F94B20", Length = "0x71")]
	[Token(Token = "0x6000516")]
	public static byte ToByte(decimal value) { }

	[Address(RVA = "0x1F95290", Offset = "0x1F94690", Length = "0x6")]
	[Token(Token = "0x600050B")]
	public static byte ToByte(bool value) { }

	[Address(RVA = "0x1F95930", Offset = "0x1F94D30", Length = "0x9D")]
	[Token(Token = "0x6000518")]
	public static byte ToByte(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F95B30", Offset = "0x1F94F30", Length = "0x45")]
	[CLSCompliant(False)]
	[Token(Token = "0x600050D")]
	public static byte ToByte(sbyte value) { }

	[Address(RVA = "0x1F95670", Offset = "0x1F94A70", Length = "0xAB")]
	[Token(Token = "0x600050A")]
	public static byte ToByte(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F95550", Offset = "0x1F94950", Length = "0x4B")]
	[Token(Token = "0x600050E")]
	public static byte ToByte(short value) { }

	[Address(RVA = "0x1F95A20", Offset = "0x1F94E20", Length = "0x10B")]
	[Token(Token = "0x60005A5")]
	public static byte ToByte(string value, int fromBase) { }

	[Address(RVA = "0x1F95BD0", Offset = "0x1F94FD0", Length = "0x9A")]
	[Token(Token = "0x6000509")]
	public static byte ToByte(object value) { }

	[Address(RVA = "0x1F95EA0", Offset = "0x1F952A0", Length = "0x9A")]
	[Token(Token = "0x60004EE")]
	public static char ToChar(object value) { }

	[Address(RVA = "0x1F95D90", Offset = "0x1F95190", Length = "0xB1")]
	[Token(Token = "0x60004F9")]
	public static char ToChar(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F95F40", Offset = "0x1F95340", Length = "0xE8")]
	[Token(Token = "0x60004F8")]
	public static char ToChar(string value) { }

	[Address(RVA = "0x1F95D40", Offset = "0x1F95140", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004F7")]
	public static char ToChar(ulong value) { }

	[Address(RVA = "0x1F95E50", Offset = "0x1F95250", Length = "0x4A")]
	[Token(Token = "0x60004F6")]
	public static char ToChar(long value) { }

	[Address(RVA = "0x1F96080", Offset = "0x1F95480", Length = "0x48")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004F5")]
	public static char ToChar(uint value) { }

	[Address(RVA = "0x1F961D0", Offset = "0x1F955D0", Length = "0x48")]
	[Token(Token = "0x60004F4")]
	public static char ToChar(int value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004F3")]
	public static char ToChar(ushort value) { }

	[Address(RVA = "0x1F96030", Offset = "0x1F95430", Length = "0x46")]
	[Token(Token = "0x60004F2")]
	public static char ToChar(short value) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x60004F1")]
	public static char ToChar(byte value) { }

	[Address(RVA = "0x1F960D0", Offset = "0x1F954D0", Length = "0x45")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004F0")]
	public static char ToChar(sbyte value) { }

	[Address(RVA = "0x1F96120", Offset = "0x1F95520", Length = "0xAB")]
	[Token(Token = "0x60004EF")]
	public static char ToChar(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96220", Offset = "0x1F95620", Length = "0xDE")]
	[Token(Token = "0x600059F")]
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96300", Offset = "0x1F95700", Length = "0x86")]
	[Token(Token = "0x60005A0")]
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F965F0", Offset = "0x1F959F0", Length = "0x63")]
	[Token(Token = "0x6000597")]
	public static decimal ToDecimal(int value) { }

	[Address(RVA = "0x1F96900", Offset = "0x1F95D00", Length = "0x63")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000598")]
	public static decimal ToDecimal(uint value) { }

	[Address(RVA = "0x1F96470", Offset = "0x1F95870", Length = "0x65")]
	[Token(Token = "0x6000599")]
	public static decimal ToDecimal(long value) { }

	[Address(RVA = "0x1F96820", Offset = "0x1F95C20", Length = "0x65")]
	[CLSCompliant(False)]
	[Token(Token = "0x600059A")]
	public static decimal ToDecimal(ulong value) { }

	[Address(RVA = "0x1F96390", Offset = "0x1F95790", Length = "0x66")]
	[Token(Token = "0x600059B")]
	public static decimal ToDecimal(float value) { }

	[Address(RVA = "0x1F96890", Offset = "0x1F95C90", Length = "0x66")]
	[Token(Token = "0x600059C")]
	public static decimal ToDecimal(double value) { }

	[Address(RVA = "0x1F96970", Offset = "0x1F95D70", Length = "0xAE")]
	[Token(Token = "0x600059D")]
	public static decimal ToDecimal(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96660", Offset = "0x1F95A60", Length = "0x64")]
	[Token(Token = "0x600059E")]
	public static decimal ToDecimal(bool value) { }

	[Address(RVA = "0x1F96740", Offset = "0x1F95B40", Length = "0x66")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000593")]
	public static decimal ToDecimal(sbyte value) { }

	[Address(RVA = "0x1F967B0", Offset = "0x1F95BB0", Length = "0x65")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000596")]
	public static decimal ToDecimal(ushort value) { }

	[Address(RVA = "0x1F964E0", Offset = "0x1F958E0", Length = "0x106")]
	[Token(Token = "0x6000592")]
	public static decimal ToDecimal(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96400", Offset = "0x1F95800", Length = "0x66")]
	[Token(Token = "0x6000594")]
	public static decimal ToDecimal(byte value) { }

	[Address(RVA = "0x1F966D0", Offset = "0x1F95AD0", Length = "0x65")]
	[Token(Token = "0x6000595")]
	public static decimal ToDecimal(short value) { }

	[Address(RVA = "0x1F96C80", Offset = "0x1F96080", Length = "0x19")]
	[Token(Token = "0x6000590")]
	public static double ToDouble(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96B10", Offset = "0x1F95F10", Length = "0x9B")]
	[Token(Token = "0x6000584")]
	public static double ToDouble(object value) { }

	[Address(RVA = "0x1F96AA0", Offset = "0x1F95EA0", Length = "0x54")]
	[Token(Token = "0x600058F")]
	public static double ToDouble(decimal value) { }

	[Address(RVA = "0x1F96C70", Offset = "0x1F96070", Length = "0x5")]
	[Token(Token = "0x600058E")]
	public static double ToDouble(float value) { }

	[Address(RVA = "0x1F96A60", Offset = "0x1F95E60", Length = "0x24")]
	[CLSCompliant(False)]
	[Token(Token = "0x600058D")]
	public static double ToDouble(ulong value) { }

	[Address(RVA = "0x1F96C60", Offset = "0x1F96060", Length = "0xB")]
	[CLSCompliant(False)]
	[Token(Token = "0x600058B")]
	public static double ToDouble(uint value) { }

	[Address(RVA = "0x1F96A30", Offset = "0x1F95E30", Length = "0x9")]
	[Token(Token = "0x600058A")]
	public static double ToDouble(int value) { }

	[Address(RVA = "0x1F96A90", Offset = "0x1F95E90", Length = "0xC")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000589")]
	public static double ToDouble(ushort value) { }

	[Address(RVA = "0x1F96CA0", Offset = "0x1F960A0", Length = "0xC")]
	[Token(Token = "0x6000588")]
	public static double ToDouble(short value) { }

	[Address(RVA = "0x1F96B00", Offset = "0x1F95F00", Length = "0xC")]
	[Token(Token = "0x6000587")]
	public static double ToDouble(byte value) { }

	[Address(RVA = "0x1F96A20", Offset = "0x1F95E20", Length = "0xC")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000586")]
	public static double ToDouble(sbyte value) { }

	[Address(RVA = "0x1F96BB0", Offset = "0x1F95FB0", Length = "0xAC")]
	[Token(Token = "0x6000585")]
	public static double ToDouble(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96A50", Offset = "0x1F95E50", Length = "0xE")]
	[Token(Token = "0x6000591")]
	public static double ToDouble(bool value) { }

	[Address(RVA = "0x1F96A40", Offset = "0x1F95E40", Length = "0x9")]
	[Token(Token = "0x600058C")]
	public static double ToDouble(long value) { }

	[Address(RVA = "0x1F97080", Offset = "0x1F96480", Length = "0x18")]
	[Token(Token = "0x6000527")]
	public static short ToInt16(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96FA0", Offset = "0x1F963A0", Length = "0x71")]
	[Token(Token = "0x6000526")]
	public static short ToInt16(decimal value) { }

	[Address(RVA = "0x1F972B0", Offset = "0x1F966B0", Length = "0x96")]
	[Token(Token = "0x6000525")]
	public static short ToInt16(double value) { }

	[Address(RVA = "0x1F970A0", Offset = "0x1F964A0", Length = "0xCB")]
	[Token(Token = "0x6000524")]
	public static short ToInt16(float value) { }

	[Address(RVA = "0x1F96E20", Offset = "0x1F96220", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000523")]
	public static short ToInt16(ulong value) { }

	[Address(RVA = "0x1F96DC0", Offset = "0x1F961C0", Length = "0x50")]
	[Token(Token = "0x6000522")]
	public static short ToInt16(long value) { }

	[Address(RVA = "0x1F97260", Offset = "0x1F96660", Length = "0x48")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000521")]
	public static short ToInt16(uint value) { }

	[Address(RVA = "0x1F97210", Offset = "0x1F96610", Length = "0x4D")]
	[Token(Token = "0x6000520")]
	public static short ToInt16(int value) { }

	[Address(RVA = "0x1F96CC0", Offset = "0x1F960C0", Length = "0x4B")]
	[CLSCompliant(False)]
	[Token(Token = "0x600051F")]
	public static short ToInt16(ushort value) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x600051E")]
	public static short ToInt16(byte value) { }

	[Address(RVA = "0x1F97070", Offset = "0x1F96470", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600051D")]
	public static short ToInt16(sbyte value) { }

	[Address(RVA = "0x1F97020", Offset = "0x1F96420", Length = "0x4B")]
	[Token(Token = "0x600051C")]
	public static short ToInt16(char value) { }

	[Address(RVA = "0x1F96CB0", Offset = "0x1F960B0", Length = "0x8")]
	[Token(Token = "0x600051B")]
	public static short ToInt16(bool value) { }

	[Address(RVA = "0x1F96D10", Offset = "0x1F96110", Length = "0xAB")]
	[Token(Token = "0x600051A")]
	public static short ToInt16(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F97170", Offset = "0x1F96570", Length = "0x9A")]
	[Token(Token = "0x6000519")]
	public static short ToInt16(object value) { }

	[Address(RVA = "0x1F96E70", Offset = "0x1F96270", Length = "0x127")]
	[Token(Token = "0x60005A7")]
	public static short ToInt16(string value, int fromBase) { }

	[Address(RVA = "0x1F97820", Offset = "0x1F96C20", Length = "0xE1")]
	[Token(Token = "0x60005A9")]
	public static int ToInt32(string value, int fromBase) { }

	[Address(RVA = "0x1F973C0", Offset = "0x1F967C0", Length = "0x18")]
	[Token(Token = "0x6000546")]
	public static int ToInt32(string value, IFormatProvider provider) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[Token(Token = "0x600053A")]
	public static int ToInt32(char value) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x600053B")]
	public static int ToInt32(byte value) { }

	[Address(RVA = "0x1F974E0", Offset = "0x1F968E0", Length = "0xAB")]
	[Token(Token = "0x6000538")]
	public static int ToInt32(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F976A0", Offset = "0x1F96AA0", Length = "0x9A")]
	[Token(Token = "0x6000537")]
	public static int ToInt32(object value) { }

	[Address(RVA = "0x1F96CB0", Offset = "0x1F960B0", Length = "0x8")]
	[Token(Token = "0x6000539")]
	public static int ToInt32(bool value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600053D")]
	public static int ToInt32(ushort value) { }

	[Address(RVA = "0x1F97490", Offset = "0x1F96890", Length = "0x47")]
	[CLSCompliant(False)]
	[Token(Token = "0x600053E")]
	public static int ToInt32(uint value) { }

	[Address(RVA = "0x1F97690", Offset = "0x1F96A90", Length = "0x4")]
	[Token(Token = "0x600053C")]
	public static int ToInt32(short value) { }

	[Address(RVA = "0x1F97740", Offset = "0x1F96B40", Length = "0x52")]
	[Token(Token = "0x6000540")]
	public static int ToInt32(long value) { }

	[Address(RVA = "0x1F973E0", Offset = "0x1F967E0", Length = "0x49")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000541")]
	public static int ToInt32(ulong value) { }

	[Address(RVA = "0x1F97430", Offset = "0x1F96830", Length = "0x54")]
	[Token(Token = "0x6000542")]
	public static int ToInt32(float value) { }

	[Address(RVA = "0x1F97590", Offset = "0x1F96990", Length = "0xFF")]
	[Token(Token = "0x6000543")]
	public static int ToInt32(double value) { }

	[Address(RVA = "0x1F977A0", Offset = "0x1F96BA0", Length = "0x71")]
	[Token(Token = "0x6000544")]
	public static int ToInt32(decimal value) { }

	[Address(RVA = "0x1F97350", Offset = "0x1F96750", Length = "0x61")]
	[Token(Token = "0x6000545")]
	public static int ToInt32(string value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x600053F")]
	public static int ToInt32(int value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[CLSCompliant(False)]
	[Token(Token = "0x600055F")]
	public static long ToInt64(uint value) { }

	[Address(RVA = "0x1F97C00", Offset = "0x1F97000", Length = "0x18")]
	[Token(Token = "0x6000565")]
	public static long ToInt64(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F97DD0", Offset = "0x1F971D0", Length = "0x61")]
	[Token(Token = "0x6000564")]
	public static long ToInt64(string value) { }

	[Address(RVA = "0x1F97AC0", Offset = "0x1F96EC0", Length = "0x71")]
	[Token(Token = "0x6000563")]
	public static long ToInt64(decimal value) { }

	[Address(RVA = "0x1F97CA0", Offset = "0x1F970A0", Length = "0x8B")]
	[Token(Token = "0x6000562")]
	public static long ToInt64(double value) { }

	[Address(RVA = "0x1F97C40", Offset = "0x1F97040", Length = "0x50")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000560")]
	public static long ToInt64(ulong value) { }

	[Address(RVA = "0x1F97C20", Offset = "0x1F97020", Length = "0x4")]
	[Token(Token = "0x600055E")]
	public static long ToInt64(int value) { }

	[Address(RVA = "0x1F97B50", Offset = "0x1F96F50", Length = "0xAB")]
	[Token(Token = "0x6000557")]
	public static long ToInt64(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F97B40", Offset = "0x1F96F40", Length = "0x5")]
	[Token(Token = "0x600055C")]
	public static long ToInt64(short value) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x600055B")]
	public static long ToInt64(byte value) { }

	[Address(RVA = "0x1F97C30", Offset = "0x1F97030", Length = "0x5")]
	[CLSCompliant(False)]
	[Token(Token = "0x600055A")]
	public static long ToInt64(sbyte value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[Token(Token = "0x6000559")]
	public static long ToInt64(char value) { }

	[Address(RVA = "0x1F97E40", Offset = "0x1F97240", Length = "0x6")]
	[Token(Token = "0x6000558")]
	public static long ToInt64(bool value) { }

	[Address(RVA = "0x1F97910", Offset = "0x1F96D10", Length = "0xE1")]
	[Token(Token = "0x60005AB")]
	public static long ToInt64(string value, int fromBase) { }

	[Address(RVA = "0x1F97D30", Offset = "0x1F97130", Length = "0x9A")]
	[Token(Token = "0x6000556")]
	public static long ToInt64(object value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600055D")]
	public static long ToInt64(ushort value) { }

	[Address(RVA = "0x1F97A00", Offset = "0x1F96E00", Length = "0xC0")]
	[Token(Token = "0x6000561")]
	public static long ToInt64(float value) { }

	[Address(RVA = "0x1F98170", Offset = "0x1F97570", Length = "0x71")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000507")]
	public static sbyte ToSByte(decimal value) { }

	[Address(RVA = "0x1F981F0", Offset = "0x1F975F0", Length = "0x134")]
	[CLSCompliant(False)]
	[Token(Token = "0x60005A6")]
	public static sbyte ToSByte(string value, int fromBase) { }

	[Address(RVA = "0x1F98110", Offset = "0x1F97510", Length = "0x10")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000508")]
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F983E0", Offset = "0x1F977E0", Length = "0x47")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004FD")]
	public static sbyte ToSByte(char value) { }

	[Address(RVA = "0x1F98040", Offset = "0x1F97440", Length = "0xCB")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000505")]
	public static sbyte ToSByte(float value) { }

	[Address(RVA = "0x1F98430", Offset = "0x1F97830", Length = "0x47")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000504")]
	public static sbyte ToSByte(ulong value) { }

	[Address(RVA = "0x1F97FE0", Offset = "0x1F973E0", Length = "0x50")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000503")]
	public static sbyte ToSByte(long value) { }

	[Address(RVA = "0x1F97F90", Offset = "0x1F97390", Length = "0x45")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000502")]
	public static sbyte ToSByte(uint value) { }

	[Address(RVA = "0x1F98390", Offset = "0x1F97790", Length = "0x4D")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000501")]
	public static sbyte ToSByte(int value) { }

	[Address(RVA = "0x1F98120", Offset = "0x1F97520", Length = "0x47")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000500")]
	public static sbyte ToSByte(ushort value) { }

	[Address(RVA = "0x1F98330", Offset = "0x1F97730", Length = "0x52")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004FF")]
	public static sbyte ToSByte(short value) { }

	[Address(RVA = "0x1F98480", Offset = "0x1F97880", Length = "0x46")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004FE")]
	public static sbyte ToSByte(byte value) { }

	[Address(RVA = "0x1F97E50", Offset = "0x1F97250", Length = "0x96")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000506")]
	public static sbyte ToSByte(double value) { }

	[Address(RVA = "0x1F95290", Offset = "0x1F94690", Length = "0x6")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004FC")]
	public static sbyte ToSByte(bool value) { }

	[Address(RVA = "0x1F984D0", Offset = "0x1F978D0", Length = "0xAB")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004FB")]
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F97EF0", Offset = "0x1F972F0", Length = "0x9A")]
	[CLSCompliant(False)]
	[Token(Token = "0x60004FA")]
	public static sbyte ToSByte(object value) { }

	[Address(RVA = "0x1F98870", Offset = "0x1F97C70", Length = "0x5")]
	[Token(Token = "0x600057F")]
	public static float ToSingle(double value) { }

	[Address(RVA = "0x1F98740", Offset = "0x1F97B40", Length = "0x54")]
	[Token(Token = "0x6000580")]
	public static float ToSingle(decimal value) { }

	[Address(RVA = "0x1F98710", Offset = "0x1F97B10", Length = "0x2C")]
	[CLSCompliant(False)]
	[Token(Token = "0x600057E")]
	public static float ToSingle(ulong value) { }

	[Address(RVA = "0x1F986F0", Offset = "0x1F97AF0", Length = "0x19")]
	[Token(Token = "0x6000582")]
	public static float ToSingle(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F985B0", Offset = "0x1F979B0", Length = "0x62")]
	[Token(Token = "0x6000581")]
	public static float ToSingle(string value) { }

	[Address(RVA = "0x1F98630", Offset = "0x1F97A30", Length = "0x9")]
	[Token(Token = "0x600057D")]
	public static float ToSingle(long value) { }

	[Address(RVA = "0x1F987A0", Offset = "0x1F97BA0", Length = "0xD")]
	[Token(Token = "0x6000583")]
	public static float ToSingle(bool value) { }

	[Address(RVA = "0x1F987B0", Offset = "0x1F97BB0", Length = "0x8")]
	[Token(Token = "0x600057B")]
	public static float ToSingle(int value) { }

	[Address(RVA = "0x1F98580", Offset = "0x1F97980", Length = "0xB")]
	[CLSCompliant(False)]
	[Token(Token = "0x600057A")]
	public static float ToSingle(ushort value) { }

	[Address(RVA = "0x1F985A0", Offset = "0x1F979A0", Length = "0xB")]
	[Token(Token = "0x6000579")]
	public static float ToSingle(short value) { }

	[Address(RVA = "0x1F98590", Offset = "0x1F97990", Length = "0xB")]
	[Token(Token = "0x6000578")]
	public static float ToSingle(byte value) { }

	[Address(RVA = "0x1F986E0", Offset = "0x1F97AE0", Length = "0xB")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000577")]
	public static float ToSingle(sbyte value) { }

	[Address(RVA = "0x1F987C0", Offset = "0x1F97BC0", Length = "0xAC")]
	[Token(Token = "0x6000576")]
	public static float ToSingle(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F98640", Offset = "0x1F97A40", Length = "0x9B")]
	[Token(Token = "0x6000575")]
	public static float ToSingle(object value) { }

	[Address(RVA = "0x1F98620", Offset = "0x1F97A20", Length = "0xF")]
	[CLSCompliant(False)]
	[Token(Token = "0x600057C")]
	public static float ToSingle(uint value) { }

	[Address(RVA = "0x1F98CA0", Offset = "0x1F980A0", Length = "0x86")]
	[Token(Token = "0x60005AF")]
	public static string ToString(long value, int toBase) { }

	[Address(RVA = "0x1F98BF0", Offset = "0x1F97FF0", Length = "0x86")]
	[Token(Token = "0x60005AE")]
	public static string ToString(int value, int toBase) { }

	[Address(RVA = "0x1F98A00", Offset = "0x1F97E00", Length = "0x8F")]
	[Token(Token = "0x60005AD")]
	public static string ToString(byte value, int toBase) { }

	[Address(RVA = "0x1F98C80", Offset = "0x1F98080", Length = "0x1A")]
	[Token(Token = "0x60005A4")]
	public static string ToString(int value, IFormatProvider provider) { }

	[Address(RVA = "0x1F98880", Offset = "0x1F97C80", Length = "0x174")]
	[Token(Token = "0x60005A1")]
	public static string ToString(object value) { }

	[Address(RVA = "0x1F98A90", Offset = "0x1F97E90", Length = "0x15E")]
	[Token(Token = "0x60005A2")]
	public static string ToString(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F98D30", Offset = "0x1F98130", Length = "0x42")]
	[Token(Token = "0x60005A3")]
	public static string ToString(char value, IFormatProvider provider) { }

	[Address(RVA = "0x1F991D0", Offset = "0x1F985D0", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000532")]
	public static ushort ToUInt16(ulong value) { }

	[Address(RVA = "0x1F98FE0", Offset = "0x1F983E0", Length = "0x46")]
	[CLSCompliant(False)]
	[Token(Token = "0x600052E")]
	public static ushort ToUInt16(short value) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600052D")]
	public static ushort ToUInt16(byte value) { }

	[Address(RVA = "0x1F99180", Offset = "0x1F98580", Length = "0x48")]
	[CLSCompliant(False)]
	[Token(Token = "0x600052F")]
	public static ushort ToUInt16(int value) { }

	[Address(RVA = "0x1F99220", Offset = "0x1F98620", Length = "0x48")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000530")]
	public static ushort ToUInt16(uint value) { }

	[Address(RVA = "0x1F98F70", Offset = "0x1F98370", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000531")]
	public static ushort ToUInt16(long value) { }

	[Address(RVA = "0x1F99310", Offset = "0x1F98710", Length = "0xC5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000533")]
	public static ushort ToUInt16(float value) { }

	[Address(RVA = "0x1F990E0", Offset = "0x1F984E0", Length = "0x9A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000528")]
	public static ushort ToUInt16(object value) { }

	[Address(RVA = "0x1F98EF0", Offset = "0x1F982F0", Length = "0x71")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000535")]
	public static ushort ToUInt16(decimal value) { }

	[Address(RVA = "0x1F98FC0", Offset = "0x1F983C0", Length = "0x18")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000536")]
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96CB0", Offset = "0x1F960B0", Length = "0x8")]
	[CLSCompliant(False)]
	[Token(Token = "0x600052A")]
	public static ushort ToUInt16(bool value) { }

	[Address(RVA = "0x1F99030", Offset = "0x1F98430", Length = "0xAB")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000529")]
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F98EA0", Offset = "0x1F982A0", Length = "0x45")]
	[CLSCompliant(False)]
	[Token(Token = "0x600052C")]
	public static ushort ToUInt16(sbyte value) { }

	[Address(RVA = "0x1F98D80", Offset = "0x1F98180", Length = "0x110")]
	[CLSCompliant(False)]
	[Token(Token = "0x60005A8")]
	public static ushort ToUInt16(string value, int fromBase) { }

	[Address(RVA = "0x1F99270", Offset = "0x1F98670", Length = "0x90")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000534")]
	public static ushort ToUInt16(double value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600052B")]
	public static ushort ToUInt16(char value) { }

	[Address(RVA = "0x1F99670", Offset = "0x1F98A70", Length = "0xE1")]
	[CLSCompliant(False)]
	[Token(Token = "0x60005AA")]
	public static uint ToUInt32(string value, int fromBase) { }

	[Address(RVA = "0x1F995D0", Offset = "0x1F989D0", Length = "0x9A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000547")]
	public static uint ToUInt32(object value) { }

	[Address(RVA = "0x1F99990", Offset = "0x1F98D90", Length = "0x71")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000554")]
	public static uint ToUInt32(decimal value) { }

	[Address(RVA = "0x1F998E0", Offset = "0x1F98CE0", Length = "0xAB")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000548")]
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F96CB0", Offset = "0x1F960B0", Length = "0x8")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000549")]
	public static uint ToUInt32(bool value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600054A")]
	public static uint ToUInt32(char value) { }

	[Address(RVA = "0x1F99870", Offset = "0x1F98C70", Length = "0x44")]
	[CLSCompliant(False)]
	[Token(Token = "0x600054B")]
	public static uint ToUInt32(sbyte value) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600054C")]
	public static uint ToUInt32(byte value) { }

	[Address(RVA = "0x1F993E0", Offset = "0x1F987E0", Length = "0x45")]
	[CLSCompliant(False)]
	[Token(Token = "0x600054D")]
	public static uint ToUInt32(short value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600054E")]
	public static uint ToUInt32(ushort value) { }

	[Address(RVA = "0x1F99580", Offset = "0x1F98980", Length = "0x43")]
	[CLSCompliant(False)]
	[Token(Token = "0x600054F")]
	public static uint ToUInt32(int value) { }

	[Address(RVA = "0x1F99760", Offset = "0x1F98B60", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000550")]
	public static uint ToUInt32(long value) { }

	[Address(RVA = "0x1F99530", Offset = "0x1F98930", Length = "0x4A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000551")]
	public static uint ToUInt32(ulong value) { }

	[Address(RVA = "0x1F99430", Offset = "0x1F98830", Length = "0xF9")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000552")]
	public static uint ToUInt32(float value) { }

	[Address(RVA = "0x1F997B0", Offset = "0x1F98BB0", Length = "0xB7")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000553")]
	public static uint ToUInt32(double value) { }

	[Address(RVA = "0x1F998C0", Offset = "0x1F98CC0", Length = "0x18")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000555")]
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F99A60", Offset = "0x1F98E60", Length = "0x18")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000574")]
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	[Address(RVA = "0x1F99DD0", Offset = "0x1F991D0", Length = "0x71")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000573")]
	public static ulong ToUInt64(decimal value) { }

	[Address(RVA = "0x1F99EF0", Offset = "0x1F992F0", Length = "0xE1")]
	[CLSCompliant(False)]
	[Token(Token = "0x60005AC")]
	public static ulong ToUInt64(string value, int fromBase) { }

	[Address(RVA = "0x1F99AD0", Offset = "0x1F98ED0", Length = "0xB5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000572")]
	public static ulong ToUInt64(double value) { }

	[Address(RVA = "0x1F99CE0", Offset = "0x1F990E0", Length = "0xEA")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000571")]
	public static ulong ToUInt64(float value) { }

	[Address(RVA = "0x1F99EA0", Offset = "0x1F992A0", Length = "0x46")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000570")]
	public static ulong ToUInt64(long value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[CLSCompliant(False)]
	[Token(Token = "0x600056F")]
	public static ulong ToUInt64(uint value) { }

	[Address(RVA = "0x1F99C40", Offset = "0x1F99040", Length = "0x9A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000566")]
	public static ulong ToUInt64(object value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600056D")]
	public static ulong ToUInt64(ushort value) { }

	[Address(RVA = "0x1F99A80", Offset = "0x1F98E80", Length = "0x45")]
	[CLSCompliant(False)]
	[Token(Token = "0x600056E")]
	public static ulong ToUInt64(int value) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600056B")]
	public static ulong ToUInt64(byte value) { }

	[Address(RVA = "0x1F99A10", Offset = "0x1F98E10", Length = "0x46")]
	[CLSCompliant(False)]
	[Token(Token = "0x600056A")]
	public static ulong ToUInt64(sbyte value) { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000569")]
	public static ulong ToUInt64(char value) { }

	[Address(RVA = "0x1F96CB0", Offset = "0x1F960B0", Length = "0x8")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000568")]
	public static ulong ToUInt64(bool value) { }

	[Address(RVA = "0x1F99B90", Offset = "0x1F98F90", Length = "0xAB")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000567")]
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[Address(RVA = "0x1F99E50", Offset = "0x1F99250", Length = "0x47")]
	[CLSCompliant(False)]
	[Token(Token = "0x600056C")]
	public static ulong ToUInt64(short value) { }

	[Address(RVA = "0x1F99FE0", Offset = "0x1F993E0", Length = "0x3A6")]
	[Token(Token = "0x60004CE")]
	private static bool TryDecodeFromUtf16(ReadOnlySpan<Char> utf16, Span<Byte> bytes, out int consumed, out int written) { }

	[Address(RVA = "0x1F9A390", Offset = "0x1F99790", Length = "0x606")]
	[Token(Token = "0x60005B9")]
	public static bool TryFromBase64Chars(ReadOnlySpan<Char> chars, Span<Byte> bytes, out int bytesWritten) { }

	[Address(RVA = "0x1F9A9A0", Offset = "0x1F99DA0", Length = "0x13")]
	[Token(Token = "0x60004D0")]
	private static void WriteThreeLowOrderBytes(ref byte destination, int value) { }

}

