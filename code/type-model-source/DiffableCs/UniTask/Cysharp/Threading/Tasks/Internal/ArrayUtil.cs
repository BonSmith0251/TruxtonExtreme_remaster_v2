namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200020B")]
internal static class ArrayUtil
{

	[Address(RVA = "0x726F70", Offset = "0x726370", Length = "0x5A")]
	[Token(Token = "0x6000BD6")]
	public static void EnsureCapacity(ref T[] array, int index) { }

	[Address(RVA = "0x726FD0", Offset = "0x7263D0", Length = "0xB5")]
	[Token(Token = "0x6000BD7")]
	private static void EnsureCore(ref T[] array, int index) { }

	[Address(RVA = "0x727090", Offset = "0x726490", Length = "0x4FF")]
	[Token(Token = "0x6000BD8")]
	public static ValueTuple<T[], Int32> Materialize(IEnumerable<T> source) { }

}

