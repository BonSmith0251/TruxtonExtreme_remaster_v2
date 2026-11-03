namespace System;

[Token(Token = "0x2000125")]
internal static class ParseNumbers
{

	[Address(RVA = "0x2044DF0", Offset = "0x20441F0", Length = "0xB5")]
	[Token(Token = "0x6000969")]
	private static void EatWhiteSpace(ReadOnlySpan<Char> s, ref int i) { }

	[Address(RVA = "0x2044EB0", Offset = "0x20442B0", Length = "0x1EA")]
	[Token(Token = "0x600096B")]
	private static int GrabInts(int radix, ReadOnlySpan<Char> s, ref int i, bool isUnsigned) { }

	[Address(RVA = "0x20450A0", Offset = "0x20444A0", Length = "0x1D6")]
	[Token(Token = "0x600096A")]
	private static long GrabLongs(int radix, ReadOnlySpan<Char> s, ref int i, bool isUnsigned) { }

	[Address(RVA = "0x2045280", Offset = "0x2044680", Length = "0x38E")]
	[Token(Token = "0x6000967")]
	public static string IntToString(int n, int radix, int width, char paddingChar, int flags) { }

	[Address(RVA = "0x2045610", Offset = "0x2044A10", Length = "0x58")]
	[Token(Token = "0x6000970")]
	private static bool IsDigit(char c, int radix, out int result) { }

	[Address(RVA = "0x2045670", Offset = "0x2044A70", Length = "0x43E")]
	[Token(Token = "0x6000968")]
	public static string LongToString(long n, int radix, int width, char paddingChar, int flags) { }

	[Address(RVA = "0x2045AB0", Offset = "0x2044EB0", Length = "0x2B")]
	[Token(Token = "0x6000965")]
	public static int StringToInt(ReadOnlySpan<Char> s, int radix, int flags) { }

	[Address(RVA = "0x2045AE0", Offset = "0x2044EE0", Length = "0x59C")]
	[Token(Token = "0x6000966")]
	public static int StringToInt(ReadOnlySpan<Char> s, int radix, int flags, ref int currPos) { }

	[Address(RVA = "0x2046580", Offset = "0x2045980", Length = "0x2B")]
	[Token(Token = "0x6000963")]
	public static long StringToLong(ReadOnlySpan<Char> s, int radix, int flags) { }

	[Address(RVA = "0x2046080", Offset = "0x2045480", Length = "0x4F6")]
	[Token(Token = "0x6000964")]
	public static long StringToLong(ReadOnlySpan<Char> s, int radix, int flags, ref int currPos) { }

	[Address(RVA = "0x20465B0", Offset = "0x20459B0", Length = "0x4E")]
	[Token(Token = "0x600096C")]
	private static void ThrowOverflowInt32Exception() { }

	[Address(RVA = "0x2046600", Offset = "0x2045A00", Length = "0x4E")]
	[Token(Token = "0x600096D")]
	private static void ThrowOverflowInt64Exception() { }

	[Address(RVA = "0x2046650", Offset = "0x2045A50", Length = "0x4E")]
	[Token(Token = "0x600096E")]
	private static void ThrowOverflowUInt32Exception() { }

	[Address(RVA = "0x20466A0", Offset = "0x2045AA0", Length = "0x4E")]
	[Token(Token = "0x600096F")]
	private static void ThrowOverflowUInt64Exception() { }

}

