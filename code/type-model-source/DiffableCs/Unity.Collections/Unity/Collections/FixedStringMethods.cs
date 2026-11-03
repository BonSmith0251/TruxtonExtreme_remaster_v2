namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000079")]
public static class FixedStringMethods
{

	[Address(RVA = "0x7F6210", Offset = "0x7F5610", Length = "0x88")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600050F")]
	public static FormatError Append(ref T fs, Rune rune) { }

	[Address(RVA = "0x7F6910", Offset = "0x7F5D10", Length = "0x89")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000529")]
	internal static FormatError Append(ref T fs, char a, char b) { }

	[Address(RVA = "0x7F6110", Offset = "0x7F5510", Length = "0xF1")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	[Token(Token = "0x600051B")]
	public static FormatError Append(ref T fs, string s) { }

	[Address(RVA = "0x7F5D50", Offset = "0x7F5150", Length = "0x8B")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600051A")]
	public static FormatError Append(ref T fs, Byte* utf8Bytes, int utf8BytesLength) { }

	[Address(RVA = "0x7F69A0", Offset = "0x7F5DA0", Length = "0xBC")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600052A")]
	internal static FormatError Append(ref T fs, char a, char b, char c) { }

	[Address(RVA = "0x7F62A0", Offset = "0x7F56A0", Length = "0x601")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000517")]
	public static FormatError Append(ref T fs, float input, char decimalSeparator = .) { }

	[Address(RVA = "0x7F7280", Offset = "0x7F6680", Length = "0x4C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000516")]
	public static FormatError Append(ref T fs, uint input) { }

	[Address(RVA = "0x7F5BD0", Offset = "0x7F4FD0", Length = "0xB9")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000518")]
	public static FormatError Append(ref T fs, in T2 input) { }

	[Address(RVA = "0x7F60C0", Offset = "0x7F54C0", Length = "0x49")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000514")]
	public static FormatError Append(ref T fs, int input) { }

	[Address(RVA = "0x7F6A60", Offset = "0x7F5E60", Length = "0x14D")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000513")]
	public static FormatError Append(ref T fs, long input) { }

	[Address(RVA = "0x7F5C90", Offset = "0x7F5090", Length = "0xB4")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000512")]
	public static FormatError Append(ref T fs, Rune rune, int count) { }

	[Address(RVA = "0x7F5EA0", Offset = "0x7F52A0", Length = "0x182")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600052B")]
	internal static FormatError Append(ref T fs, char a, char b, char c, char d, char e, char f, char g, char h) { }

	[Address(RVA = "0x7F68B0", Offset = "0x7F5CB0", Length = "0x52")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000510")]
	public static FormatError Append(ref T fs, char ch) { }

	[Address(RVA = "0x7F8200", Offset = "0x7F7600", Length = "0xDC")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000515")]
	public static FormatError Append(ref T fs, ulong input) { }

	[Address(RVA = "0x7F4500", Offset = "0x7F3900", Length = "0x2E8")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000524")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5) { }

	[Address(RVA = "0x7F3760", Offset = "0x7F2B60", Length = "0x370")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000528")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9) { }

	[Address(RVA = "0x7F3E80", Offset = "0x7F3280", Length = "0x32C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000526")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7) { }

	[Address(RVA = "0x7F41D0", Offset = "0x7F35D0", Length = "0x30C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000525")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6) { }

	[Address(RVA = "0x7F4800", Offset = "0x7F3C00", Length = "0x2B7")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000523")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4) { }

	[Address(RVA = "0x7F3B00", Offset = "0x7F2F00", Length = "0x350")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000527")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8) { }

	[Address(RVA = "0x7F3220", Offset = "0x7F2620", Length = "0x15F")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000521")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2) { }

	[Address(RVA = "0x7F3380", Offset = "0x7F2780", Length = "0x143")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000520")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1) { }

	[Address(RVA = "0x7F34D0", Offset = "0x7F28D0", Length = "0x108")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x600051F")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0) { }

	[Address(RVA = "0x7F35E0", Offset = "0x7F29E0", Length = "0x180")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000522")]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3) { }

	[Address(RVA = "0x7F5430", Offset = "0x7F4830", Length = "0x6C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000511")]
	public static FormatError AppendRawByte(ref T fs, byte a) { }

	[Address(RVA = "0x7F5720", Offset = "0x7F4B20", Length = "0x2A9")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600052C")]
	internal static FormatError AppendScientific(ref T fs, Char* source, int sourceLength, int decimalExponent, char decimalSeparator = .) { }

	[Address(RVA = "0x28B8380", Offset = "0x28B7780", Length = "0x19D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600052F")]
	internal static void CheckSubstringInRange(int strLength, int startIndex, int length) { }

	[Address(RVA = "0x7F8580", Offset = "0x7F7980", Length = "0x62")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000542")]
	public static int CompareTo(ref T fs, in T2 other) { }

	[Address(RVA = "0x7F85F0", Offset = "0x7F79F0", Length = "0xA5")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000541")]
	public static int CompareTo(ref T fs, Byte* bytes, int bytesLen) { }

	[Address(RVA = "0x7F8C70", Offset = "0x7F8070", Length = "0x2C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000549")]
	public static int ComputeHashCode(ref T fs) { }

	[Address(RVA = "0x7F8E60", Offset = "0x7F8260", Length = "0x53")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x600053B")]
	public static bool Contains(ref T fs, in T2 other) { }

	[Address(RVA = "0x7F8EC0", Offset = "0x7F82C0", Length = "0xB7")]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Extension]
	[Token(Token = "0x6000548")]
	public static string ConvertToString(ref T fs) { }

	[Address(RVA = "0x7F96A0", Offset = "0x7F8AA0", Length = "0xF9")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	[Token(Token = "0x600051C")]
	public static CopyError CopyFrom(ref T fs, string s) { }

	[Address(RVA = "0x7F95A0", Offset = "0x7F89A0", Length = "0xF9")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000519")]
	public static CopyError CopyFrom(ref T fs, in T2 input) { }

	[Address(RVA = "0x7F9460", Offset = "0x7F8860", Length = "0x92")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	[Token(Token = "0x600051D")]
	public static CopyError CopyFromTruncated(ref T fs, string s) { }

	[Address(RVA = "0x80B240", Offset = "0x80A640", Length = "0x3E1")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x600051E")]
	public static CopyError CopyFromTruncated(ref T fs, in T2 input) { }

	[Address(RVA = "0x80B870", Offset = "0x80AC70", Length = "0xC9")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600054A")]
	public static int EffectiveSizeOf(ref T fs) { }

	[Address(RVA = "0x80BCF0", Offset = "0x80B0F0", Length = "0x20E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600054D")]
	public static bool EndsWith(ref T fs, Rune rune) { }

	[Address(RVA = "0x80B940", Offset = "0x80AD40", Length = "0x3AC")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x600054E")]
	public static bool EndsWith(ref T fs, in U other) { }

	[Address(RVA = "0x80C090", Offset = "0x80B490", Length = "0xE8")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000544")]
	public static bool Equals(ref T fs, in T2 other) { }

	[Address(RVA = "0x80C180", Offset = "0x80B580", Length = "0x99")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000543")]
	public static bool Equals(ref T fs, Byte* bytes, int bytesLen) { }

	[Address(RVA = "0x80C3B0", Offset = "0x80B7B0", Length = "0x1A7")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600052E")]
	internal static bool Found(ref T fs, ref int offset, char a, char b, char c, char d, char e, char f, char g, char h) { }

	[Address(RVA = "0x80C560", Offset = "0x80B960", Length = "0xCA")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600052D")]
	internal static bool Found(ref T fs, ref int offset, char a, char b, char c) { }

	[Address(RVA = "0x80C9C0", Offset = "0x80BDC0", Length = "0x118")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000536")]
	public static int IndexOf(ref T fs, Rune rune) { }

	[Address(RVA = "0x80CAE0", Offset = "0x80BEE0", Length = "0x1A6")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000537")]
	public static int IndexOf(ref T fs, Byte* bytes, int bytesLen) { }

	[Address(RVA = "0x80C7D0", Offset = "0x80BBD0", Length = "0x1E7")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000538")]
	public static int IndexOf(ref T fs, Byte* bytes, int bytesLen, int startIndex, int distance = 2147483647) { }

	[Address(RVA = "0x7F6F40", Offset = "0x7F6340", Length = "0x183")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000539")]
	public static int IndexOf(ref T fs, in T2 other) { }

	[Address(RVA = "0x80C630", Offset = "0x80BA30", Length = "0x195")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x600053A")]
	public static int IndexOf(ref T fs, in T2 other, int startIndex, int distance = 2147483647) { }

	[Address(RVA = "0x80C630", Offset = "0x80BA30", Length = "0x195")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000540")]
	public static int LastIndexOf(ref T fs, in T2 other, int startIndex, int distance = 2147483647) { }

	[Address(RVA = "0x80CC90", Offset = "0x80C090", Length = "0x1F7")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600053E")]
	public static int LastIndexOf(ref T fs, Byte* bytes, int bytesLen, int startIndex, int distance = 2147483647) { }

	[Address(RVA = "0x80CFB0", Offset = "0x80C3B0", Length = "0x1AE")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600053D")]
	public static int LastIndexOf(ref T fs, Byte* bytes, int bytesLen) { }

	[Address(RVA = "0x80CE90", Offset = "0x80C290", Length = "0x120")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600053C")]
	public static int LastIndexOf(ref T fs, Rune rune) { }

	[Address(RVA = "0x7F6F40", Offset = "0x7F6340", Length = "0x183")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x600053F")]
	public static int LastIndexOf(ref T fs, in T2 other) { }

	[Address(RVA = "0x80D3D0", Offset = "0x80C7D0", Length = "0x8D")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600056D")]
	public static ParseError Parse(ref T fs, ref int offset, ref uint output) { }

	[Address(RVA = "0x80DD30", Offset = "0x80D130", Length = "0x95")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600056C")]
	public static ParseError Parse(ref T fs, ref int offset, ref int output) { }

	[Address(RVA = "0x80D460", Offset = "0x80C860", Length = "0x8CF")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600056E")]
	public static ParseError Parse(ref T fs, ref int offset, ref float output, char decimalSeparator = .) { }

	[Address(RVA = "0x80D160", Offset = "0x80C560", Length = "0x26A")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600056B")]
	internal static bool ParseLongInternal(ref T fs, ref int offset, out long value) { }

	[Address(RVA = "0x80DDD0", Offset = "0x80D1D0", Length = "0x200")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000545")]
	public static Rune Peek(ref T fs, int index) { }

	[Address(RVA = "0x80DFD0", Offset = "0x80D3D0", Length = "0x204")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000546")]
	public static Rune Read(ref T fs, ref int index) { }

	[Address(RVA = "0x80E500", Offset = "0x80D900", Length = "0x18B")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600054B")]
	public static bool StartsWith(ref T fs, Rune rune) { }

	[Address(RVA = "0x80E1E0", Offset = "0x80D5E0", Length = "0x314")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	[Token(Token = "0x600054C")]
	public static bool StartsWith(ref T fs, in U other) { }

	[Address(RVA = "0x28B8610", Offset = "0x28B7A10", Length = "0xB4")]
	[Extension]
	[Token(Token = "0x6000534")]
	public static NativeText Substring(ref NativeText str, int startIndex, int length) { }

	[Address(RVA = "0x28B8520", Offset = "0x28B7920", Length = "0x35")]
	[Extension]
	[Token(Token = "0x6000533")]
	public static NativeText Substring(ref NativeText str, int startIndex, AllocatorHandle allocator) { }

	[Address(RVA = "0x28B8560", Offset = "0x28B7960", Length = "0xA2")]
	[Extension]
	[Token(Token = "0x6000532")]
	public static NativeText Substring(ref NativeText str, int startIndex, int length, AllocatorHandle allocator) { }

	[Address(RVA = "0x80E690", Offset = "0x80DA90", Length = "0x15B")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000531")]
	public static T Substring(ref T str, int startIndex) { }

	[Address(RVA = "0x80E7F0", Offset = "0x80DBF0", Length = "0x266")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000530")]
	public static T Substring(ref T str, int startIndex, int length) { }

	[Address(RVA = "0x28B8520", Offset = "0x28B7920", Length = "0x35")]
	[Extension]
	[Token(Token = "0x6000535")]
	public static NativeText Substring(ref NativeText str, int startIndex) { }

	[Address(RVA = "0x28B87B0", Offset = "0x28B7BB0", Length = "0xC8")]
	[Extension]
	[Token(Token = "0x6000567")]
	public static NativeText ToLowerAscii(ref NativeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x28B86D0", Offset = "0x28B7AD0", Length = "0xDE")]
	[Extension]
	[Token(Token = "0x6000566")]
	public static UnsafeText ToLowerAscii(ref UnsafeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x80EA60", Offset = "0x80DE60", Length = "0x253")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000565")]
	public static T ToLowerAscii(ref T fs) { }

	[Address(RVA = "0x80ECC0", Offset = "0x80E0C0", Length = "0x253")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000568")]
	public static T ToUpperAscii(ref T fs) { }

	[Address(RVA = "0x28B8960", Offset = "0x28B7D60", Length = "0xC8")]
	[Extension]
	[Token(Token = "0x600056A")]
	public static NativeText ToUpperAscii(ref NativeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x28B8880", Offset = "0x28B7C80", Length = "0xDE")]
	[Extension]
	[Token(Token = "0x6000569")]
	public static UnsafeText ToUpperAscii(ref UnsafeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x28B9120", Offset = "0x28B8520", Length = "0x104")]
	[Extension]
	[Token(Token = "0x6000564")]
	public static NativeText Trim(ref NativeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x28B9360", Offset = "0x28B8760", Length = "0x13E")]
	[Extension]
	[Token(Token = "0x6000563")]
	public static UnsafeText Trim(ref UnsafeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x810810", Offset = "0x80FC10", Length = "0x2CD")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000562")]
	public static T Trim(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x28B9030", Offset = "0x28B8430", Length = "0xEE")]
	[Extension]
	[Token(Token = "0x6000561")]
	public static NativeText Trim(ref NativeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x28B9230", Offset = "0x28B8630", Length = "0x12E")]
	[Extension]
	[Token(Token = "0x6000560")]
	public static UnsafeText Trim(ref UnsafeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x810570", Offset = "0x80F970", Length = "0x295")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600055F")]
	public static T Trim(ref T fs) { }

	[Address(RVA = "0x28B8C30", Offset = "0x28B8030", Length = "0xB9")]
	[Extension]
	[Token(Token = "0x600055D")]
	public static UnsafeText TrimEnd(ref UnsafeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x80F7E0", Offset = "0x80EBE0", Length = "0x1D1")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600055C")]
	public static T TrimEnd(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x28B8AE0", Offset = "0x28B7EE0", Length = "0x9E")]
	[Extension]
	[Token(Token = "0x600055B")]
	public static NativeText TrimEnd(ref NativeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x80F620", Offset = "0x80EA20", Length = "0x1BD")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000559")]
	public static T TrimEnd(ref T fs) { }

	[Address(RVA = "0x28B8A30", Offset = "0x28B7E30", Length = "0xAE")]
	[Extension]
	[Token(Token = "0x600055E")]
	public static NativeText TrimEnd(ref NativeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x28B8B80", Offset = "0x28B7F80", Length = "0xA9")]
	[Extension]
	[Token(Token = "0x600055A")]
	public static UnsafeText TrimEnd(ref UnsafeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x80F3C0", Offset = "0x80E7C0", Length = "0x93")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000551")]
	internal static int TrimEndIndex(ref T fs) { }

	[Address(RVA = "0x80F2B0", Offset = "0x80E6B0", Length = "0x105")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000552")]
	internal static int TrimEndIndex(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x28B8CF0", Offset = "0x28B80F0", Length = "0xD6")]
	[Extension]
	[Token(Token = "0x6000557")]
	public static UnsafeText TrimStart(ref UnsafeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x810300", Offset = "0x80F700", Length = "0x262")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000556")]
	public static T TrimStart(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x28B8F70", Offset = "0x28B8370", Length = "0xBA")]
	[Extension]
	[Token(Token = "0x6000555")]
	public static NativeText TrimStart(ref NativeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x28B8EA0", Offset = "0x28B82A0", Length = "0xC6")]
	[Extension]
	[Token(Token = "0x6000554")]
	public static UnsafeText TrimStart(ref UnsafeText fs, AllocatorHandle allocator) { }

	[Address(RVA = "0x8100A0", Offset = "0x80F4A0", Length = "0x257")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000553")]
	public static T TrimStart(ref T fs) { }

	[Address(RVA = "0x28B8DD0", Offset = "0x28B81D0", Length = "0xCA")]
	[Extension]
	[Token(Token = "0x6000558")]
	public static NativeText TrimStart(ref NativeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x80FDD0", Offset = "0x80F1D0", Length = "0x105")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000550")]
	internal static int TrimStartIndex(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[Address(RVA = "0x80FD30", Offset = "0x80F130", Length = "0x93")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x600054F")]
	internal static int TrimStartIndex(ref T fs) { }

	[Address(RVA = "0x810AE0", Offset = "0x80FEE0", Length = "0x5B")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	[Token(Token = "0x6000547")]
	public static FormatError Write(ref T fs, ref int index, Rune rune) { }

}

