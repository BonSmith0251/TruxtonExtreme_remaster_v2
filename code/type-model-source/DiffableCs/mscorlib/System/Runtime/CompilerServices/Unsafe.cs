namespace System.Runtime.CompilerServices;

[Token(Token = "0x20004B5")]
internal static class Unsafe
{

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x600218C")]
	public static T Add(ref T source, int elementOffset) { }

	[Address(RVA = "0x9D74C0", Offset = "0x9D68C0", Length = "0x5")]
	[Token(Token = "0x600218D")]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[Address(RVA = "0x9D7630", Offset = "0x9D6A30", Length = "0x7")]
	[Token(Token = "0x600218E")]
	public static Void* Add(Void* source, int elementOffset) { }

	[Address(RVA = "0x9D74D0", Offset = "0x9D68D0", Length = "0x1F")]
	[Token(Token = "0x600219C")]
	internal static T AddByteOffset(ref T source, ulong byteOffset) { }

	[Address(RVA = "0x9D74C0", Offset = "0x9D68C0", Length = "0x5")]
	[Token(Token = "0x600218F")]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6002190")]
	public static bool AreSame(ref T left, ref T right) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002191")]
	public static T As(object o) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002192")]
	public static TTo As(ref TFrom source) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002193")]
	public static Void* AsPointer(ref T value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002195")]
	public static T AsRef(in T source) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002194")]
	public static T AsRef(Void* source) { }

	[Address(RVA = "0x1F43940", Offset = "0x1F42D40", Length = "0xB")]
	[Token(Token = "0x6002196")]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[Address(RVA = "0x9DCA70", Offset = "0x9DBE70", Length = "0x7")]
	[Token(Token = "0x600219B")]
	public static bool IsAddressLessThan(ref T left, ref T right) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6002197")]
	public static T Read(Void* source) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6002198")]
	public static T ReadUnaligned(ref byte source) { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x6002199")]
	public static int SizeOf() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600219A")]
	public static void WriteUnaligned(ref byte destination, T value) { }

}

