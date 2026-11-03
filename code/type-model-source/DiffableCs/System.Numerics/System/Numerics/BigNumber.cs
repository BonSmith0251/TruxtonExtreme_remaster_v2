namespace System.Numerics;

[Token(Token = "0x2000006")]
internal static class BigNumber
{
	[Token(Token = "0x2000007")]
	private struct BigNumberBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000010")]
		public StringBuilder digits; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000011")]
		public int precision; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000012")]
		public int scale; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000013")]
		public bool sign; //Field offset: 0x10

		[Address(RVA = "0x23E6070", Offset = "0x23E5470", Length = "0x6A")]
		[Token(Token = "0x600006C")]
		public static BigNumberBuffer Create() { }

	}


	[Address(RVA = "0x23E6830", Offset = "0x23E5C30", Length = "0xE2")]
	[Token(Token = "0x600006A")]
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	[Address(RVA = "0x23E6920", Offset = "0x23E5D20", Length = "0xCE0")]
	[Token(Token = "0x600006B")]
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<Char> formatSpan, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	[Address(RVA = "0x23E60E0", Offset = "0x23E54E0", Length = "0x742")]
	[Token(Token = "0x6000069")]
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	[Address(RVA = "0x23E7610", Offset = "0x23E6A10", Length = "0x28A")]
	[Token(Token = "0x6000066")]
	private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	[Address(RVA = "0x23E78A0", Offset = "0x23E6CA0", Length = "0x2CC")]
	[Token(Token = "0x6000067")]
	private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	[Address(RVA = "0x23E7B70", Offset = "0x23E6F70", Length = "0x1FE")]
	[Token(Token = "0x6000064")]
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x23E7D70", Offset = "0x23E7170", Length = "0x162")]
	[Token(Token = "0x6000065")]
	internal static BigInteger ParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x23E7EE0", Offset = "0x23E72E0", Length = "0x138")]
	[Token(Token = "0x6000068")]
	internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

	[Address(RVA = "0x23E8020", Offset = "0x23E7420", Length = "0x35A")]
	[Token(Token = "0x6000063")]
	internal static bool TryParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	[Address(RVA = "0x23E8380", Offset = "0x23E7780", Length = "0x161")]
	[Token(Token = "0x6000062")]
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

}

