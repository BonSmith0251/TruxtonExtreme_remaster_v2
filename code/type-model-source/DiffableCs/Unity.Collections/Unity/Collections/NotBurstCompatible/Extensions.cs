namespace Unity.Collections.NotBurstCompatible;

[Extension]
[Token(Token = "0x20000FD")]
public static class Extensions
{

	[Address(RVA = "0x7F0C50", Offset = "0x7F0050", Length = "0xA2")]
	[ExcludeFromBurstCompatTesting("Takes managed array")]
	[Extension]
	[Token(Token = "0x6000ACE")]
	public static void CopyFromNBC(NativeList<T> list, T[] array) { }

	[Address(RVA = "0x7F0F20", Offset = "0x7F0320", Length = "0x94")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	[Token(Token = "0x6000ACB")]
	public static T[] ToArray(NativeHashSet<T> set) { }

	[Address(RVA = "0x7F0E90", Offset = "0x7F0290", Length = "0x90")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	[Token(Token = "0x6000ACC")]
	public static T[] ToArray(NativeParallelHashSet<T> set) { }

	[Address(RVA = "0x7F0E20", Offset = "0x7F0220", Length = "0x61")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	[Token(Token = "0x6000ACD")]
	public static T[] ToArrayNBC(NativeList<T> list) { }

}

