namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20000CF")]
internal static class BufferUtils
{

	[Address(RVA = "0x2119F60", Offset = "0x2119360", Length = "0xA0")]
	[Token(Token = "0x6000646")]
	public static Char[] EnsureBufferSize(IArrayPool<Char> bufferPool, int size, Char[] buffer) { }

	[Address(RVA = "0x211A000", Offset = "0x2119400", Length = "0x72")]
	[NullableContext(1)]
	[Token(Token = "0x6000644")]
	public static Char[] RentBuffer(IArrayPool<Char> bufferPool, int minSize) { }

	[Address(RVA = "0x211A080", Offset = "0x2119480", Length = "0x53")]
	[Token(Token = "0x6000645")]
	public static void ReturnBuffer(IArrayPool<Char> bufferPool, Char[] buffer) { }

}

