namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000FE")]
public static class DataStreamExtensions
{

	[Address(RVA = "0x28C66C0", Offset = "0x28C5AC0", Length = "0x94")]
	[Token(Token = "0x6000ACF")]
	public static DataStreamWriter Create(Byte* data, int length) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Extension]
	[Token(Token = "0x6000AD4")]
	public static Void* GetUnsafeReadOnlyPtr(ref DataStreamReader reader) { }

	[Address(RVA = "0x28C6760", Offset = "0x28C5B60", Length = "0x81")]
	[Extension]
	[Token(Token = "0x6000AD1")]
	public static void ReadBytesUnsafe(ref DataStreamReader reader, Byte* data, int length) { }

	[Address(RVA = "0x28C67F0", Offset = "0x28C5BF0", Length = "0x81")]
	[Extension]
	[Token(Token = "0x6000AD2")]
	public static ushort ReadFixedStringUnsafe(ref DataStreamReader reader, Byte* data, int maxLength) { }

	[Address(RVA = "0x28C6880", Offset = "0x28C5C80", Length = "0xD4")]
	[Extension]
	[Token(Token = "0x6000AD3")]
	public static ushort ReadPackedFixedStringDeltaUnsafe(ref DataStreamReader reader, Byte* data, int maxLength, Byte* baseData, ushort baseLength, StreamCompressionModel model) { }

	[Address(RVA = "0x28C6960", Offset = "0x28C5D60", Length = "0x81")]
	[Extension]
	[Token(Token = "0x6000AD0")]
	public static bool WriteBytesUnsafe(ref DataStreamWriter writer, Byte* data, int bytes) { }

}

