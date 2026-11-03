namespace System.Net;

[Token(Token = "0x2000225")]
internal class IPAddressParser
{

	[Address(RVA = "0x26A7630", Offset = "0x26A6A30", Length = "0x98")]
	[Token(Token = "0x6000E7F")]
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	[Address(RVA = "0x26A76D0", Offset = "0x26A6AD0", Length = "0x1DB")]
	[Token(Token = "0x6000E7E")]
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	[Address(RVA = "0x26A78B0", Offset = "0x26A6CB0", Length = "0x4C")]
	[Token(Token = "0x6000E80")]
	private static uint ExtractIPv4Address(UInt16[] address) { }

	[Address(RVA = "0x26A7900", Offset = "0x26A6D00", Length = "0xB8")]
	[Token(Token = "0x6000E7B")]
	private static void FormatIPv4AddressNumber(int number, Char* addressString, ref int offset) { }

	[Address(RVA = "0x26A7BE0", Offset = "0x26A6FE0", Length = "0x5D")]
	[Token(Token = "0x6000E76")]
	internal static string IPv4AddressToString(uint address) { }

	[Address(RVA = "0x26A7C40", Offset = "0x26A7040", Length = "0x6A")]
	[Token(Token = "0x6000E77")]
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	[Address(RVA = "0x26A79C0", Offset = "0x26A6DC0", Length = "0x215")]
	[Token(Token = "0x6000E78")]
	private static int IPv4AddressToStringHelper(uint address, Char* addressString) { }

	[Address(RVA = "0x26A8180", Offset = "0x26A7580", Length = "0xDF")]
	[Token(Token = "0x6000E7C")]
	public static bool Ipv4StringToAddress(ReadOnlySpan<Char> ipSpan, out long address) { }

	[Address(RVA = "0x26A8160", Offset = "0x26A7560", Length = "0x1A")]
	[Token(Token = "0x6000E79")]
	internal static string IPv6AddressToString(UInt16[] address, uint scopeId) { }

	[Address(RVA = "0x26A7CB0", Offset = "0x26A70B0", Length = "0x4A4")]
	[Token(Token = "0x6000E7A")]
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, uint scopeId) { }

	[Address(RVA = "0x26A8260", Offset = "0x26A7660", Length = "0x15A")]
	[Token(Token = "0x6000E7D")]
	public static bool Ipv6StringToAddress(ReadOnlySpan<Char> ipSpan, UInt16* numbers, int numbersLength, out uint scope) { }

	[Address(RVA = "0x26A83C0", Offset = "0x26A77C0", Length = "0x3EF")]
	[Token(Token = "0x6000E75")]
	internal static IPAddress Parse(ReadOnlySpan<Char> ipSpan, bool tryParse) { }

	[Address(RVA = "0x1FD37D0", Offset = "0x1FD2BD0", Length = "0x8")]
	[Token(Token = "0x6000E81")]
	private static ushort Reverse(ushort number) { }

}

