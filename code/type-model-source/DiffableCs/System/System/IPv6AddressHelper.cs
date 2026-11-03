namespace System;

[Token(Token = "0x20000B3")]
internal static class IPv6AddressHelper
{

	[Address(RVA = "0x25FB390", Offset = "0x25FA790", Length = "0xCC")]
	[Token(Token = "0x6000355")]
	internal static ValueTuple<Int32, Int32> FindCompressionRange(ReadOnlySpan<UInt16> numbers) { }

	[Address(RVA = "0x25FB460", Offset = "0x25FA860", Length = "0x2B7")]
	[Token(Token = "0x600035B")]
	private static bool InternalIsValid(Char* name, int start, ref int end, bool validateStrictAddress) { }

	[Address(RVA = "0x25FB720", Offset = "0x25FAB20", Length = "0xD9")]
	[Token(Token = "0x600035A")]
	private static bool IsLoopback(ReadOnlySpan<UInt16> numbers) { }

	[Address(RVA = "0x25FBB50", Offset = "0x25FAF50", Length = "0x1A")]
	[Token(Token = "0x600035C")]
	internal static bool IsValid(Char* name, int start, ref int end) { }

	[Address(RVA = "0x25FB800", Offset = "0x25FAC00", Length = "0x341")]
	[Token(Token = "0x6000357")]
	internal static bool IsValidStrict(Char* name, int start, ref int end) { }

	[Address(RVA = "0x25FC3E0", Offset = "0x25FB7E0", Length = "0x480")]
	[Token(Token = "0x6000358")]
	internal static void Parse(ReadOnlySpan<Char> address, UInt16* numbers, int start, ref string scopeId) { }

	[Address(RVA = "0x25FBB70", Offset = "0x25FAF70", Length = "0x864")]
	[Token(Token = "0x6000359")]
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	[Address(RVA = "0x25FC870", Offset = "0x25FBC70", Length = "0xD3")]
	[Token(Token = "0x6000356")]
	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<UInt16> numbers) { }

}

