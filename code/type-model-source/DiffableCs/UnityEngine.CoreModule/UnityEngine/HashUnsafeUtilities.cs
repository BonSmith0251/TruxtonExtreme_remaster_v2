namespace UnityEngine;

[Token(Token = "0x2000141")]
public static class HashUnsafeUtilities
{

	[Address(RVA = "0x3049BB0", Offset = "0x3048FB0", Length = "0xE")]
	[Token(Token = "0x6000FAF")]
	public static void ComputeHash128(Void* data, ulong dataSize, UInt64* hash1, UInt64* hash2) { }

	[Address(RVA = "0x3049B50", Offset = "0x3048F50", Length = "0x5E")]
	[Token(Token = "0x6000FB0")]
	public static void ComputeHash128(Void* data, ulong dataSize, Hash128* hash) { }

}

