namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000067")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AudioModule"})]
internal static class BurstRuntime
{
	[Token(Token = "0x2000068")]
	private struct HashCode64
	{
		[Token(Token = "0x4000111")]
		public static readonly long Value; //Field offset: 0x0

		[Address(RVA = "0x1C421A0", Offset = "0x1C415A0", Length = "0xBF")]
		[Token(Token = "0x6000143")]
		private static HashCode64`1() { }

	}


	[Address(RVA = "0x79B410", Offset = "0x79A810", Length = "0x75")]
	[Token(Token = "0x6000141")]
	public static long GetHashCode64() { }

	[Address(RVA = "0x27BED80", Offset = "0x27BE180", Length = "0x81")]
	[Token(Token = "0x6000142")]
	internal static long HashStringWithFNV1A64(string text) { }

}

