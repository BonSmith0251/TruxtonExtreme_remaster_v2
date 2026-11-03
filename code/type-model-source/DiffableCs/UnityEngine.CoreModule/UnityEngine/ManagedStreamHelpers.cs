namespace UnityEngine;

[Token(Token = "0x20001B5")]
internal static class ManagedStreamHelpers
{

	[Address(RVA = "0x30659B0", Offset = "0x3064DB0", Length = "0xB7")]
	[RequiredByNativeCode]
	[Token(Token = "0x60013B7")]
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

	[Address(RVA = "0x3065A70", Offset = "0x3064E70", Length = "0xF1")]
	[RequiredByNativeCode]
	[Token(Token = "0x60013B5")]
	internal static void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[Address(RVA = "0x3065B70", Offset = "0x3064F70", Length = "0xD9")]
	[RequiredByNativeCode]
	[Token(Token = "0x60013B6")]
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[Address(RVA = "0x3065C50", Offset = "0x3065050", Length = "0x166")]
	[Token(Token = "0x60013B4")]
	internal static void ValidateLoadFromStream(Stream stream) { }

}

