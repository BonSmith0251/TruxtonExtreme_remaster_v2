namespace Unity.Burst;

[Token(Token = "0x2000002")]
internal static class Unsafe
{

	[Address(RVA = "0x9D7790", Offset = "0x9D6B90", Length = "0x4D")]
	[NonVersionable]
	[Token(Token = "0x600001A")]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[Address(RVA = "0x9D7740", Offset = "0x9D6B40", Length = "0x4C")]
	[NonVersionable]
	[Token(Token = "0x6000019")]
	public static Void* Add(Void* source, int elementOffset) { }

	[Address(RVA = "0x9D77E0", Offset = "0x9D6BE0", Length = "0x4D")]
	[NonVersionable]
	[Token(Token = "0x6000018")]
	public static T Add(ref T source, int elementOffset) { }

	[Address(RVA = "0x9D74C0", Offset = "0x9D68C0", Length = "0x5")]
	[NonVersionable]
	[Token(Token = "0x600001B")]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x6000021")]
	public static bool AreSame(ref T left, ref T right) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x6000016")]
	public static TTo As(ref TFrom source) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x6000013")]
	public static T As(object o) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x6000009")]
	public static Void* AsPointer(ref T value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x6000015")]
	public static T AsRef(ref T source) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x6000014")]
	public static T AsRef(Void* source) { }

	[Address(RVA = "0x9DC990", Offset = "0x9DBD90", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x6000020")]
	public static IntPtr ByteOffset(ref T origin, ref T target) { }

	[Address(RVA = "0x9DC9A0", Offset = "0x9DBDA0", Length = "0xBE")]
	[NonVersionable]
	[Token(Token = "0x6000007")]
	public static void Copy(Void* destination, ref T source) { }

	[Address(RVA = "0x9DC9A0", Offset = "0x9DBDA0", Length = "0xBE")]
	[NonVersionable]
	[Token(Token = "0x6000008")]
	public static void Copy(ref T destination, Void* source) { }

	[Address(RVA = "0x27E5DB0", Offset = "0x27E51B0", Length = "0x6B")]
	[NonVersionable]
	[Token(Token = "0x600000B")]
	public static void CopyBlock(Void* destination, Void* source, uint byteCount) { }

	[Address(RVA = "0x27E5DB0", Offset = "0x27E51B0", Length = "0x6B")]
	[NonVersionable]
	[Token(Token = "0x600000C")]
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[Address(RVA = "0x27E5DB0", Offset = "0x27E51B0", Length = "0x6B")]
	[NonVersionable]
	[Token(Token = "0x600000D")]
	public static void CopyBlockUnaligned(Void* destination, Void* source, uint byteCount) { }

	[Address(RVA = "0x27E5DB0", Offset = "0x27E51B0", Length = "0x6B")]
	[NonVersionable]
	[Token(Token = "0x600000E")]
	public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount) { }

	[Address(RVA = "0x1F43940", Offset = "0x1F42D40", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x600000F")]
	public static void InitBlock(Void* startAddress, byte value, uint byteCount) { }

	[Address(RVA = "0x1F43940", Offset = "0x1F42D40", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x6000010")]
	public static void InitBlock(ref byte startAddress, byte value, uint byteCount) { }

	[Address(RVA = "0x1F43940", Offset = "0x1F42D40", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x6000011")]
	public static void InitBlockUnaligned(Void* startAddress, byte value, uint byteCount) { }

	[Address(RVA = "0x1F43940", Offset = "0x1F42D40", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x6000012")]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[Address(RVA = "0x9DCA60", Offset = "0x9DBE60", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x6000022")]
	public static bool IsAddressGreaterThan(ref T left, ref T right) { }

	[Address(RVA = "0x9DCA70", Offset = "0x9DBE70", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x6000023")]
	public static bool IsAddressLessThan(ref T left, ref T right) { }

	[Address(RVA = "0x9DCA80", Offset = "0x9DBE80", Length = "0x96")]
	[NonVersionable]
	[Token(Token = "0x6000001")]
	public static T Read(Void* source) { }

	[Address(RVA = "0x9DCA80", Offset = "0x9DBE80", Length = "0x96")]
	[NonVersionable]
	[Token(Token = "0x6000003")]
	public static T ReadUnaligned(ref byte source) { }

	[Address(RVA = "0x9DCA80", Offset = "0x9DBE80", Length = "0x96")]
	[NonVersionable]
	[Token(Token = "0x6000002")]
	public static T ReadUnaligned(Void* source) { }

	[Address(RVA = "0x9DCC90", Offset = "0x9DC090", Length = "0x28")]
	[NonVersionable]
	[Token(Token = "0x600000A")]
	public static int SizeOf() { }

	[Address(RVA = "0x9DCEC0", Offset = "0x9DC2C0", Length = "0x50")]
	[NonVersionable]
	[Token(Token = "0x600001C")]
	public static T Subtract(ref T source, int elementOffset) { }

	[Address(RVA = "0x9DCE70", Offset = "0x9DC270", Length = "0x4F")]
	[NonVersionable]
	[Token(Token = "0x600001D")]
	public static Void* Subtract(Void* source, int elementOffset) { }

	[Address(RVA = "0x9DCE20", Offset = "0x9DC220", Length = "0x50")]
	[NonVersionable]
	[Token(Token = "0x600001E")]
	public static T Subtract(ref T source, IntPtr elementOffset) { }

	[Address(RVA = "0x9DCE10", Offset = "0x9DC210", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x600001F")]
	public static T SubtractByteOffset(ref T source, IntPtr byteOffset) { }

	[Address(RVA = "0x9DCF10", Offset = "0x9DC310", Length = "0x69")]
	[NonVersionable]
	[Token(Token = "0x6000017")]
	public static T Unbox(object box) { }

	[Address(RVA = "0x9DCF80", Offset = "0x9DC380", Length = "0x2331")]
	[NonVersionable]
	[Token(Token = "0x6000004")]
	public static void Write(Void* destination, T value) { }

	[Address(RVA = "0x9DCF80", Offset = "0x9DC380", Length = "0x2331")]
	[NonVersionable]
	[Token(Token = "0x6000006")]
	public static void WriteUnaligned(ref byte destination, T value) { }

	[Address(RVA = "0x9DCF80", Offset = "0x9DC380", Length = "0x2331")]
	[NonVersionable]
	[Token(Token = "0x6000005")]
	public static void WriteUnaligned(Void* destination, T value) { }

}

