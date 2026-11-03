namespace System;

[Token(Token = "0x20000B2")]
internal static class IPv4AddressHelper
{

	[Address(RVA = "0x25FAAD0", Offset = "0x25F9ED0", Length = "0x187")]
	[Token(Token = "0x600034F")]
	internal static bool IsValid(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	[Address(RVA = "0x25FA990", Offset = "0x25F9D90", Length = "0x13C")]
	[Token(Token = "0x6000351")]
	internal static bool IsValidCanonical(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	[Address(RVA = "0x25FB300", Offset = "0x25FA700", Length = "0x8C")]
	[Token(Token = "0x6000354")]
	private static bool Parse(string name, Byte* numbers, int start, int end) { }

	[Address(RVA = "0x25FAF00", Offset = "0x25FA300", Length = "0x8F")]
	[Token(Token = "0x6000350")]
	private static bool ParseCanonical(ReadOnlySpan<Char> name, Byte* numbers, int start, int end) { }

	[Address(RVA = "0x25FAC60", Offset = "0x25FA060", Length = "0x290")]
	[Token(Token = "0x6000353")]
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	[Address(RVA = "0x25FAF90", Offset = "0x25FA390", Length = "0xC7")]
	[Token(Token = "0x600034E")]
	internal static int ParseHostNumber(ReadOnlySpan<Char> str, int start, int end) { }

	[Address(RVA = "0x25FB060", Offset = "0x25FA460", Length = "0x299")]
	[Token(Token = "0x6000352")]
	internal static long ParseNonCanonical(Char* name, int start, ref int end, bool notImplicitFile) { }

}

