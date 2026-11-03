namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200021D")]
internal static class StatePool
{
	[Token(Token = "0x40005D7")]
	private static readonly ConcurrentQueue<StateTuple`3<T1, T2, T3>> queue; //Field offset: 0x0

	[Address(RVA = "0xFCE410", Offset = "0xFCD810", Length = "0xF6")]
	[Token(Token = "0x6000C45")]
	private static StatePool`3() { }

	[Address(RVA = "0xFCD970", Offset = "0xFCCD70", Length = "0x1CF")]
	[Token(Token = "0x6000C43")]
	public static StateTuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3) { }

	[Address(RVA = "0xFCE320", Offset = "0xFCD720", Length = "0xEF")]
	[Token(Token = "0x6000C44")]
	public static void Return(StateTuple<T1, T2, T3> tuple) { }

}

