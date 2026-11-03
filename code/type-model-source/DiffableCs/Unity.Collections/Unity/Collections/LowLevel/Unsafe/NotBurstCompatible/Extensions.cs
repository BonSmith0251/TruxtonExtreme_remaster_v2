namespace Unity.Collections.LowLevel.Unsafe.NotBurstCompatible;

[Extension]
[Token(Token = "0x200014C")]
public static class Extensions
{

	[Address(RVA = "0x28C6AE0", Offset = "0x28C5EE0", Length = "0xA7")]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	[Token(Token = "0x6000DC3")]
	public static void AddNBC(ref UnsafeAppendBuffer buffer, string value) { }

	[Address(RVA = "0x28C6B90", Offset = "0x28C5F90", Length = "0xF2")]
	[ExcludeFromBurstCompatTesting("Managed string out argument")]
	[Extension]
	[Token(Token = "0x6000DC5")]
	public static void ReadNextNBC(ref Reader reader, out string value) { }

	[Address(RVA = "0x7F0E90", Offset = "0x7F0290", Length = "0x90")]
	[Extension]
	[Token(Token = "0x6000DC2")]
	public static T[] ToArray(UnsafeParallelHashSet<T> set) { }

	[Address(RVA = "0x28C6C90", Offset = "0x28C6090", Length = "0x73")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	[Token(Token = "0x6000DC4")]
	public static Byte[] ToBytesNBC(ref UnsafeAppendBuffer buffer) { }

}

