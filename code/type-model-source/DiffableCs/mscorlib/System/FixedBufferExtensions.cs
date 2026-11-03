namespace System;

[Extension]
[Token(Token = "0x200015C")]
internal static class FixedBufferExtensions
{

	[Address(RVA = "0x2042D40", Offset = "0x2042140", Length = "0xC7")]
	[Extension]
	[Token(Token = "0x6000C51")]
	internal static bool FixedBufferEqualsString(ReadOnlySpan<Char> span, string value) { }

	[Address(RVA = "0x2042E10", Offset = "0x2042210", Length = "0x59")]
	[Extension]
	[Token(Token = "0x6000C50")]
	internal static int GetFixedBufferStringLength(ReadOnlySpan<Char> span) { }

	[Address(RVA = "0x2042E70", Offset = "0x2042270", Length = "0xB7")]
	[Extension]
	[Token(Token = "0x6000C4F")]
	internal static string GetStringFromFixedBuffer(ReadOnlySpan<Char> span) { }

}

