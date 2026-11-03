namespace System;

[ComVisible(True)]
[Token(Token = "0x2000181")]
public static class Buffer
{

	[Address(RVA = "0x205CE10", Offset = "0x205C210", Length = "0x5")]
	[Token(Token = "0x6000DB6")]
	private static int _ByteLength(Array array) { }

	[Address(RVA = "0x205C540", Offset = "0x205B940", Length = "0x287")]
	[Token(Token = "0x6000DBB")]
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[Address(RVA = "0x205C7D0", Offset = "0x205BBD0", Length = "0xAB")]
	[Token(Token = "0x6000DBA")]
	public static int ByteLength(Array array) { }

	[Address(RVA = "0x205C880", Offset = "0x205BC80", Length = "0xAF")]
	[Token(Token = "0x6000DB5")]
	internal static int IndexOfByte(Byte* src, byte value, int index, int count) { }

	[Address(RVA = "0x205C930", Offset = "0x205BD30", Length = "0x5")]
	[Token(Token = "0x6000DB4")]
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	[Address(RVA = "0x205C940", Offset = "0x205BD40", Length = "0x5")]
	[Token(Token = "0x6000DB9")]
	internal static void InternalMemcpy(Byte* dest, Byte* src, int count) { }

	[Address(RVA = "0x205CC40", Offset = "0x205C040", Length = "0x48")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000DB8")]
	internal static void Memcpy(Byte* pDest, int destIndex, Byte[] src, int srcIndex, int len) { }

	[Address(RVA = "0x205C950", Offset = "0x205BD50", Length = "0x2E2")]
	[Token(Token = "0x6000DC0")]
	internal static void Memcpy(Byte* dest, Byte* src, int len) { }

	[Address(RVA = "0x205CE20", Offset = "0x205C220", Length = "0xA5")]
	[Token(Token = "0x6000DBF")]
	private static void memcpy1(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x205CED0", Offset = "0x205C2D0", Length = "0x80")]
	[Token(Token = "0x6000DBE")]
	internal static void memcpy2(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x205CF50", Offset = "0x205C350", Length = "0x93")]
	[Token(Token = "0x6000DBD")]
	internal static void memcpy4(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x205CC90", Offset = "0x205C090", Length = "0x2C")]
	[Token(Token = "0x6000DC1")]
	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	[Address(RVA = "0x79AD20", Offset = "0x79A120", Length = "0xA6")]
	[Token(Token = "0x6000DC2")]
	internal static void Memmove(ref T destination, ref T source, ulong elementCount) { }

	[Address(RVA = "0x205CCC0", Offset = "0x205C0C0", Length = "0x121")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000DBC")]
	public static void MemoryCopy(Void* source, Void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	[Address(RVA = "0x205CDF0", Offset = "0x205C1F0", Length = "0x20")]
	[Token(Token = "0x6000DB7")]
	internal static void ZeroMemory(Byte* src, long len) { }

}

