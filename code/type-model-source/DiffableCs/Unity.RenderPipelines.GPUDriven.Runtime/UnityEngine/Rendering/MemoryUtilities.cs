namespace UnityEngine.Rendering;

[Token(Token = "0x20000E9")]
internal static class MemoryUtilities
{

	[Address(RVA = "0x883E40", Offset = "0x883240", Length = "0x8")]
	[Token(Token = "0x60003BE")]
	public static void Free(T* p, Allocator allocator) { }

	[Address(RVA = "0x883EB0", Offset = "0x8832B0", Length = "0x57")]
	[Token(Token = "0x60003BD")]
	public static T* Malloc(int count, Allocator allocator) { }

}

