namespace System.Runtime;

[Token(Token = "0x2000343")]
public static class RuntimeImports
{

	[Address(RVA = "0x1EEEB30", Offset = "0x1EEDF30", Length = "0x5")]
	[Token(Token = "0x6001A6B")]
	internal static void _ecvt_s(Byte* buffer, int sizeInBytes, double value, int count, Int32* dec, Int32* sign) { }

	[Address(RVA = "0x1EEEB00", Offset = "0x1EEDF00", Length = "0x5")]
	[Token(Token = "0x6001A69")]
	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	[Address(RVA = "0x1EEEB10", Offset = "0x1EEDF10", Length = "0x5")]
	[Token(Token = "0x6001A6A")]
	internal static void Memmove_wbarrier(Byte* dest, Byte* src, uint len, IntPtr type_handle) { }

	[Address(RVA = "0x1EEEB20", Offset = "0x1EEDF20", Length = "0x5")]
	[Token(Token = "0x6001A67")]
	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	[Address(RVA = "0x1EEEB20", Offset = "0x1EEDF20", Length = "0x5")]
	[Token(Token = "0x6001A68")]
	private static void ZeroMemory(Void* p, uint byteLength) { }

}

