namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[Token(Token = "0x2000149")]
internal static class UnsafeTextExtensions
{

	[Address(RVA = "0x28D3B80", Offset = "0x28D2F80", Length = "0x2E")]
	[Extension]
	[Token(Token = "0x6000DA4")]
	public static UnsafeList<Byte>& AsUnsafeListOfBytes(ref UnsafeText text) { }

	[Address(RVA = "0x28D3B30", Offset = "0x28D2F30", Length = "0x4A")]
	[Extension]
	[Token(Token = "0x6000DA5")]
	public static UnsafeList<Byte> AsUnsafeListOfBytesRO(UnsafeText text) { }

}

