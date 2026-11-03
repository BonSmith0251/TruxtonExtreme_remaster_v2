namespace UnityEngine;

[Token(Token = "0x2000142")]
internal static class SpookyHash
{
	[Token(Token = "0x2000143")]
	private struct U
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000413")]
		public Byte* p8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000414")]
		public UInt32* p32; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000415")]
		public UInt64* p64; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000416")]
		public ulong i; //Field offset: 0x0

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x6000FB9")]
		public U(UInt16* p8) { }

	}


	[Address(RVA = "0x304F860", Offset = "0x304EC60", Length = "0x1EC")]
	[Token(Token = "0x6000FB2")]
	private static void End(UInt64* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	[Address(RVA = "0x304F690", Offset = "0x304EA90", Length = "0x1C3")]
	[Token(Token = "0x6000FB3")]
	private static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	[Address(RVA = "0x304FA50", Offset = "0x304EE50", Length = "0x6EE")]
	[Token(Token = "0x6000FB1")]
	public static void Hash(Void* message, ulong length, UInt64* hash1, UInt64* hash2) { }

	[Address(RVA = "0x3050140", Offset = "0x304F540", Length = "0x27E")]
	[Token(Token = "0x6000FB8")]
	private static void Mix(UInt64* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11) { }

	[Address(RVA = "0x30497C0", Offset = "0x3048BC0", Length = "0x20")]
	[Token(Token = "0x6000FB4")]
	private static void Rot64(ref ulong x, int k) { }

	[Address(RVA = "0x3050530", Offset = "0x304F930", Length = "0x524")]
	[Token(Token = "0x6000FB5")]
	private static void Short(Void* message, ulong length, UInt64* hash1, UInt64* hash2) { }

	[Address(RVA = "0x30497E0", Offset = "0x3048BE0", Length = "0x142")]
	[Token(Token = "0x6000FB7")]
	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	[Address(RVA = "0x30503C0", Offset = "0x304F7C0", Length = "0x170")]
	[Token(Token = "0x6000FB6")]
	private static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

}

